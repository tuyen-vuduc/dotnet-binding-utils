﻿using System.Text.Json.Nodes;

namespace Binderator.Gradle;

public static class ArtifactScanner
{
    static readonly string[] skippedArtifacts = new[] {
        "junit",
        "jsr305",
    };
    static readonly string[] skippedGroups = new[] {
        "androidx.test",
        "org.json"
    };

    public static List<ArtifactModel> Scan(
        List<ArtifactModel> existingArtifacts,
        string basePath,
        string artifactString,
        Action<string> log)
    {
        List<ArtifactModel> artifacts = new();

        var artifact = Util.FromArtifactString(basePath, artifactString, true);
        artifact.Nuget.DependencyOnly = false;
        artifacts.Add(artifact);

        var homeFolder = Environment.SpecialFolder.UserProfile;
        var homeFolderPath = Environment.GetFolderPath(homeFolder);

        var (artifactVersionFolderPath, artifactFiles) = GetArtifactFiles(
            homeFolderPath,
            artifact.Group.Id,
            artifact.Nuget.ArtifactId,
            artifact.Version.SemanticVersion
        );

        if (artifactFiles.Length == 0)
        {
            log?.Invoke(
                $"ARTIFACT FOLDER MISSING >> {artifact.GradleImplementation} << {artifactVersionFolderPath}"
            );
            return artifacts;
        }
        artifact.Files = artifactFiles;

        var artifactModuleFileName = $"{artifact.Nuget.ArtifactId}-{artifact.Version.SemanticVersion}.module";
        var moduleFilePath = artifactFiles.FirstOrDefault(x => x.EndsWith(artifactModuleFileName));
        if (!string.IsNullOrWhiteSpace(moduleFilePath))
        {
            moduleFilePath = Path.Combine(homeFolderPath, moduleFilePath);
            var jsonNode = JsonNode.Parse(File.OpenRead(moduleFilePath));
            var variantsNode = jsonNode["variants"] as JsonArray;
            var jvmApiElementsPublishedNode = variantsNode
                .FirstOrDefault(
                    x => x["name"].GetValue<string>() == "jvmApiElements-published"
                        || x["name"].GetValue<string>() == "releaseApiElements-published"
                );

            if (jvmApiElementsPublishedNode != null)
            {
                var availableAtNode = jvmApiElementsPublishedNode["available-at"];
                if (availableAtNode != null)
                {
                    var shadowGroup = availableAtNode["group"].GetValue<string>();
                    var shadowArtifactId = availableAtNode["module"].GetValue<string>();
                    var shadowVersion = availableAtNode["version"].GetValue<string>();
                    var parentArtifacts = Scan(
                        existingArtifacts,
                        basePath,
                        $"{shadowGroup}:{shadowArtifactId}:{shadowVersion}",
                        log);

                    var shadowArtifact = parentArtifacts.FirstOrDefault(x => x.Nuget.ArtifactId == shadowArtifactId && x.Group.Id == shadowGroup);

                    artifact.ParentArtifacts = [new KeyValuePair<string, string>(shadowArtifact.Nuget.PackageId, "compile")];
                    artifacts.Add(artifact);

                    artifacts.AddRange(parentArtifacts);
                    existingArtifacts.AddRange(parentArtifacts);
                    artifacts = artifacts.Distinct().ToList();

                    return artifacts;
                }
            }
        }

        // TODO Handle managed dependencies (BOM)
        var pomFilePath = artifactFiles.FirstOrDefault(x => x.EndsWith(".pom"));

        if (pomFilePath == null)
        {
            var libFilePath = artifactFiles.FirstOrDefault(x =>
                !x.Contains("_aar") &&
                (x.EndsWith($".aar") ||
                x.EndsWith($".jar"))
            );

            if (!string.IsNullOrWhiteSpace(libFilePath))
            {
                artifacts.Add(artifact);
            }

            return artifacts;
        }

        var xmlDocument = new XmlDocument();
        xmlDocument.Load(
            Path.Combine(
                homeFolderPath,
                pomFilePath
            )
        );

        // Add the namespace.  
        XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDocument.NameTable);
        nsmgr.AddNamespace("mvn", "http://maven.apache.org/POM/4.0.0");

        artifact.Packaging = xmlDocument.DocumentElement.SelectSingleNode("descendant::mvn:packaging", nsmgr)?.InnerText;

        var dependencies = xmlDocument.DocumentElement.SelectNodes("mvn:dependencies/mvn:dependency", nsmgr);

        var parentArtifactIds = new List<KeyValuePair<string, string>>();
        foreach (XmlNode dependency in dependencies)
        {
            var xartifactId = dependency.SelectSingleNode("descendant::mvn:artifactId", nsmgr).InnerText;

            // TODO Why artifact adds junit as a compile dependency?
            if (skippedArtifacts.Contains(xartifactId)) continue;

            if (xartifactId.EndsWith("-darwin")) continue;

            // TODO neeed to handle optional dependencies
            var optional = dependency.SelectSingleNode("descendant::mvn:optional", nsmgr)?.InnerText;
            if (!string.IsNullOrWhiteSpace(optional)
               && bool.TryParse(optional, out var isOptional))
            {
                continue;
            }

            var scope = dependency.SelectSingleNode("descendant::mvn:scope", nsmgr)?.InnerText;
            if (scope == "test" || scope == "provided") continue;

            var xgroupId = dependency.SelectSingleNode("descendant::mvn:groupId", nsmgr).InnerText;
            if (skippedGroups.Contains(xgroupId)) continue;

            if (string.IsNullOrWhiteSpace(scope))
            {
                //var missed = missingDependencies.Any(x =>
                //    x == $"{xgroupId}:{xartifactId}:" ||
                //    x.StartsWith($"{xgroupId}:{xartifactId}:"));

                //if (!missed) continue;

                // TODO Why scope is N/A for a normal dependency
                scope = "compile";
            }

            var existingArtifact = existingArtifacts.FirstOrDefault(
                    x => x.Group.Id == xgroupId && x.Nuget.ArtifactId == xartifactId
                );

            // TODO Handle version range
            var rawVersion = dependency.SelectSingleNode("descendant::mvn:version", nsmgr)?.InnerText;
            var xversion = rawVersion;

            if (xversion == null)
            {
                if (existingArtifact == null) continue;

                xversion = existingArtifact.Version.SemanticVersion.ToNormalizedString();
            }
            else if (xversion.StartsWith("${"))
            {
                xversion = GetVersion(xmlDocument, nsmgr, xversion);
            }
            else if (xversion.Contains("-${"))
            {
                var xversions = xversion.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                xversions[1] = GetVersion(xmlDocument, nsmgr, xversions[1]);

                xversion = string.Join("-", xversions);
            }
            else if (rawVersion.StartsWith("[")
                && VersionRange.TryParse(rawVersion, out var versionRange))
            {
                xversion = versionRange.IsMaxInclusive
                    ? versionRange.MaxVersion.ToNormalizedString()
                    : versionRange.MinVersion.ToNormalizedString();
            }
            else if (rawVersion.Contains("+"))
            {
                continue;
            }

            AddParentArtifact(
                existingArtifacts,
                xgroupId, xartifactId, xversion,
                existingArtifact, parentArtifactIds, log,
                homeFolderPath, scope,
                basePath, ref artifacts);
        }

        var missingParentJsonPath = Path.Combine(
            basePath,
            artifact.RelativeFolderPath,
            $"{artifact.Version.SemanticVersion.ToNormalizedString()}.missing.json"
            );
        if (File.Exists(missingParentJsonPath))
        {
            var missingParents = Util.Deserialize<string[]>(
                File.OpenRead(missingParentJsonPath)
            );

            foreach (var missingParent in missingParents)
            {
                var existingArtifact = existingArtifacts
                    .FirstOrDefault(x => x.GradleImplementation == missingParent);
                var missingParts = missingParent.Split(':');
                AddParentArtifact(
                    existingArtifacts,
                    missingParts[0],
                    missingParts[1],
                    missingParts[2],
                    existingArtifact, parentArtifactIds, log,
                    homeFolderPath,
                    "compile",
                    basePath, ref artifacts);
            }
        }

        var fixedVersionJsonPath = Path.Combine(
            basePath,
            artifact.RelativeFolderPath,
            $"{artifact.Version.SemanticVersion.ToNormalizedString()}.fixed.json"
            );
        var nonExistingFixedVersions = new List<KeyValuePair<string, string>>();
        if (File.Exists(fixedVersionJsonPath))
        {
            var fixedVersions = Util.Deserialize<Dictionary<string, string>>(
                File.OpenRead(fixedVersionJsonPath)
            );
            nonExistingFixedVersions = fixedVersions.ToList();
        }

        artifact.ParentArtifacts = parentArtifactIds.ToArray();
        artifact.FixedVersions = nonExistingFixedVersions.ToArray();

        return artifacts;
    }

    private static ArtifactModel AddParentArtifact(
        List<ArtifactModel> existingArtifacts,
        string xgroupId,
        string xartifactId,
        string xversion,
        ArtifactModel existingArtifact,
        List<KeyValuePair<string, string>> parentArtifactIds,
        Action<string> log,
        string homeFolderPath,
        string scope,
        string basePath,
        ref List<ArtifactModel> artifacts)
    {
        SemanticVersion artifactVersion = SemanticVersion.TryParse(xversion, out var semanticVersion)
            ? semanticVersion
            : NuGetVersion.Parse(xversion);

        if (existingArtifact != null)
        {
            var existingNugetPackageId = existingArtifact.Nuget.PackageId
                ?? CreateNugetId(xgroupId, xartifactId);
            parentArtifactIds.Add(new KeyValuePair<string, string>(existingNugetPackageId, scope));

            if (artifactVersion != existingArtifact.Version.SemanticVersion)
            {
                log?.Invoke(
                    $"ARTIFACT EXISTS >> {xgroupId}:{xartifactId}-{xversion} << {existingArtifact.Version.SemanticVersion.ToNormalizedString()}"
                );

                if (existingArtifact.Version.SemanticVersion < artifactVersion)
                {
                    var (_, xartifactFiles) = GetArtifactFiles(
                        homeFolderPath,
                        xgroupId,
                        xartifactId,
                        artifactVersion
                    );
                    existingArtifact.Files = xartifactFiles;
                    existingArtifact.Version.SemanticVersion = artifactVersion;
                }
            }

            return existingArtifact;
        }

        var parentArtifact = FindExternalArtifact(basePath, xgroupId, xartifactId, artifactVersion);

        if (parentArtifact.Version == null || !parentArtifact.Nuget.DependencyOnly)
        {
            var parentVersion = (parentArtifact.Version?.SemanticVersion ?? artifactVersion).ToNormalizedString();
            var parentArtifacts = Scan(
                existingArtifacts,
                basePath,
                $"{parentArtifact.Group?.Id ?? xgroupId}:{parentArtifact.Nuget?.ArtifactId ?? xartifactId}:{parentVersion}",
                log);

            if (parentArtifacts.Count == 0) return null;

            artifacts.AddRange(parentArtifacts);
            existingArtifacts.AddRange(parentArtifacts);
            artifacts = artifacts.Distinct().ToList();
            parentArtifactIds.Add(new KeyValuePair<string, string>(parentArtifacts[0].Nuget.PackageId, scope));
            parentArtifacts[0].Nuget.DependencyOnly = false;

            return parentArtifacts[0];
        }
        else
        {
            if (artifactVersion != parentArtifact.Version.SemanticVersion)
            {
                log?.Invoke(
                    $"EXTERNAL ARTIFACT >> {xgroupId}:{xartifactId}-{xversion} << {parentArtifact.Version.SemanticVersion.ToNormalizedString()}"
                );
            }

            artifacts.Add(parentArtifact);
            parentArtifactIds.Add(new KeyValuePair<string, string>(parentArtifact.Nuget.PackageId, scope));
            return parentArtifact;
        }
    }

    private static string GetVersion(XmlDocument xmlDocument, XmlNamespaceManager nsmgr, string xversion)
    {
        while (xversion.StartsWith("${"))
        {
            var propertyName = xversion.Trim('$', '{', '}');

            xversion = propertyName switch
            {
                "project.parent.version" => xmlDocument.SelectSingleNode($"mvn:project/mvn:parent/mvn:version", nsmgr).InnerText,
                "project.version" => xmlDocument.SelectSingleNode($"mvn:project/mvn:version", nsmgr).InnerText,
                _ => xmlDocument.SelectSingleNode($"descendant::mvn:properties/mvn:{propertyName}", nsmgr).InnerText
            };
        }
        return xversion;
    }

    private static (string, string[]) GetArtifactFiles(
        string homeFolderPath,
        string groupId,
        string artifactId,
        SemanticVersion version)
    {
        var (artifactVersionFolderPath, exists) = GetArtifactVersionFolderPath(
            homeFolderPath,
            groupId,
            artifactId,
            version
        );

        if (!exists) return (
            artifactVersionFolderPath,
            Array.Empty<string>()
        );

        var files = Directory.GetFiles(
            artifactVersionFolderPath,
            "*.*",
            SearchOption.AllDirectories
        );

        return (
            artifactVersionFolderPath,
            files
                .Where(x => !x.Contains("/_aar/"))
                .Select(x => x.Replace(homeFolderPath, string.Empty).Trim('/').Trim('\\'))
                .ToArray()
        );
    }

    private static (string, bool) GetArtifactVersionFolderPath(
        string homeFolderPath,
        string groupId,
        string artifactId,
        SemanticVersion version)
    {
        var artifactVersionFolderPath = Path.Combine(
            homeFolderPath,
            $".gradle/caches/modules-2/files-2.1/{groupId}/{artifactId}/{version}"
        );

        if (Directory.Exists(artifactVersionFolderPath))
        {
            return (artifactVersionFolderPath, true);
        }

        if (version.Patch == 0)
        {
            artifactVersionFolderPath = Path.Combine(
                homeFolderPath,
                $".gradle/caches/modules-2/files-2.1/{groupId}/{artifactId}/{version.Major}.{version.Minor}"
            );

            if (!string.IsNullOrWhiteSpace(version.Release))
            {
                artifactVersionFolderPath += $"-{version.Release}";
            }
        }

        if (Directory.Exists(artifactVersionFolderPath))
        {
            return (artifactVersionFolderPath, true);
        }

        if (version.Minor == 0)
        {
            artifactVersionFolderPath = Path.Combine(
                homeFolderPath,
                $".gradle/caches/modules-2/files-2.1/{groupId}/{artifactId}/{version.Major}"
            );

            if (!string.IsNullOrWhiteSpace(version.Release))
            {
                artifactVersionFolderPath += $"-{version.Release}";
            }
        }

        return (
            artifactVersionFolderPath,
            Directory.Exists(artifactVersionFolderPath)
        );
    }

    private static ArtifactModel FindExternalArtifact(string basePath, string xgroupId, string xartifactId, SemanticVersion xversion)
    {
        ArtifactModel artifact = Util.FromArtifactString(basePath, $"{xgroupId}:{xartifactId}:{xversion}", false);

        if (!string.IsNullOrWhiteSpace(artifact.Nuget?.Relocated))
        {
            var relocatedParts = artifact.Nuget.Relocated.Split(':');
            return FindExternalArtifact(basePath, relocatedParts[0], relocatedParts[1], xversion);
        }

        if (artifact.Version?.FallbackVersion is not null)
        {
            return FindExternalArtifact(basePath, xgroupId, xartifactId, artifact.Version.FallbackVersion);
        }

        return artifact;
    }

    static string CreateNugetId(string groupId, string artifactId)
    {
        return string.Join(
                ".",
                groupId.Split('.')
                    .Select(x => x.ToCSharpName())
                ) + "." + artifactId.ToCSharpName();
    }
}
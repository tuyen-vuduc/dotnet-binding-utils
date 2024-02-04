using Microsoft.Extensions.DependencyModel;
using System;
using System.Text.Json.Nodes;
using System.Xml;

namespace Binderator.Gradle;

public static class ArtifactScanner
{
    public static List<ArtifactModel> Scan(
        string metadataBasePath,
        string groupId,
        string artifactId,
        string version,
        Action<string> log)
    {
        return Scan(new(), metadataBasePath, groupId, artifactId, NuGetVersion.Parse(version), log, missingArtifacts: new());
    }

    static readonly string[] skippedDependencies = new[] {
        "junit",
        "jsr305",
    };

    public static List<ArtifactModel> Scan(
        List<ArtifactModel> existingArtifacts,
        string basePath,
        string groupId,
        string artifactId,
        SemanticVersion version,
        Action<string> log,
        string groupName = default,
        string artifactName = default,
        string[] tags = default,
        int nugetRevision = default,
        string nugetPackageId = default,
        string[] missingDependencies = default,
        List<string> missingArtifacts = default)
    {
        List<ArtifactModel> artifacts = new();
        missingArtifacts ??= new();

        var homeFolder = Platform.IsWindows
                    ? Environment.SpecialFolder.UserProfile
                    : Environment.SpecialFolder.Personal;
        var homeFolderPath = Environment.GetFolderPath(homeFolder);

        var (artifactVersionFolderPath, artifactFiles) = GetArtifactFiles(
            homeFolderPath,
            groupId,
            artifactId,
            version
        );

        if (artifactFiles.Length == 0)
        {
            log?.Invoke(
                $"ARTIFACT FOLDER MISSING >> {groupId}:{artifactId}:{version} << {artifactVersionFolderPath}"
            );
            missingArtifacts.Add($"{groupId}:{artifactId}-{version} << {artifactVersionFolderPath}");

            return artifacts;
        }

        var artifact = new ArtifactModel
        {
            GroupId = groupId,
            GroupName = groupName,
            ArtifactId = artifactId,
            ArtifactName = artifactName,
            Version = version,
            NugetVersion = version.ToNuGetVersion(nugetRevision),
            NugetPackageId = nugetPackageId ?? CreateNugetId(groupId, artifactId),
            ParentArtifacts = new KeyValuePair<string, string>[0],
            Files = artifactFiles,
            Tags = tags,
        };

        var artifactModuleFileName = $"{artifactId}-{version}.module";
        var moduleFilePath = artifactFiles.FirstOrDefault(x => x.EndsWith(artifactModuleFileName));
        if (!string.IsNullOrWhiteSpace(moduleFilePath))
        {
            moduleFilePath = Path.Combine(homeFolderPath, moduleFilePath);
            var jsonNode = JsonNode.Parse(File.OpenRead(moduleFilePath));
            var variantsNode = jsonNode["variants"] as JsonArray;
            var jvmApiElementsPublishedNode = variantsNode.FirstOrDefault(x => x["name"].GetValue<string>() == "jvmApiElements-published");

            if (jvmApiElementsPublishedNode != null)
            {
                var availableAtNode = jvmApiElementsPublishedNode["available-at"];
                if (availableAtNode != null)
                {
                    var shadowGroup = availableAtNode["group"].GetValue<string>();
                    var shadowArtifactId = availableAtNode["module"].GetValue<string>();
                    var shadowVersion = SemanticVersion.Parse(availableAtNode["version"].GetValue<string>());
                    var parentArtifacts = Scan(
                        existingArtifacts,
                        basePath,
                        shadowGroup,
                        shadowArtifactId,
                        shadowVersion,
                        log,
                        nugetRevision: nugetRevision,
                        nugetPackageId: artifact?.NugetPackageId,
                        missingDependencies: artifact?.MissingDependencies ?? Array.Empty<string>(),
                        missingArtifacts: missingArtifacts);

                    var shadowArtifact = parentArtifacts.FirstOrDefault(x => x.ArtifactId == shadowArtifactId && x.GroupId == shadowGroup);
                    parentArtifacts.Remove(shadowArtifact);

                    artifact.ShadowArtifact = shadowArtifact;
                    artifacts.Add(artifact);

                    artifacts.AddRange(parentArtifacts);
                    existingArtifacts.AddRange(parentArtifacts);
                    artifacts = artifacts.Distinct().ToList();

                    return artifacts;
                }
            }
        }

        var pomFilePath = artifactFiles.FirstOrDefault(x => x.EndsWith(".pom"));

        if (pomFilePath == null)
        {
            var libFilePath = artifactFiles.FirstOrDefault(x =>
                x.EndsWith($"{artifactId}-{version}.aar") ||
                x.EndsWith($"{artifactId}-{version}.jar")
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
        artifacts.Add(artifact);

        var dependencies = xmlDocument.DocumentElement.SelectNodes("mvn:dependencies/mvn:dependency", nsmgr);

        var parentArtifactIds = new List<KeyValuePair<string, string>>();
        foreach (XmlNode dependency in dependencies)
        {
            var scope = dependency.SelectSingleNode("descendant::mvn:scope", nsmgr)?.InnerText;
            if (scope == "test") continue;

            var xartifactId = dependency.SelectSingleNode("descendant::mvn:artifactId", nsmgr).InnerText;

            // TODO Why artifact adds junit as a compile dependency?
            if (skippedDependencies.Contains(xartifactId)) continue;

            var xgroupId = dependency.SelectSingleNode("descendant::mvn:groupId", nsmgr).InnerText;

            if (string.IsNullOrWhiteSpace(scope))
            {
                var missed = missingDependencies.Any(x =>
                    x == $"{xgroupId}:{xartifactId}:" ||
                    x.StartsWith($"{xgroupId}:{xartifactId}:"));

                if (!missed) continue;

                // TODO Why scope is N/A for a normal dependency
                scope = "compile";
            }

            var existingArtifact = existingArtifacts.FirstOrDefault(
                    x => x.GroupId == xgroupId && x.ArtifactId == xartifactId
                );

            // TODO Handle version range
            var rawVersion = dependency.SelectSingleNode("descendant::mvn:version", nsmgr)?.InnerText;
            var xversion = rawVersion;

            if (xversion == null)
            {
                if (existingArtifact == null) continue;

                xversion = existingArtifact.Version.ToNormalizedString();
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
            else if (VersionRange.TryParse(rawVersion, out var versionRange))
            {
                xversion = versionRange.IsMaxInclusive
                    ? versionRange.MaxVersion.ToNormalizedString()
                    : versionRange.MinVersion.ToNormalizedString();
            }

            AddParentArtifact(
                existingArtifacts,
                xgroupId, xartifactId, xversion,
                existingArtifact, parentArtifactIds, log,
                homeFolderPath, scope, nugetRevision,
                basePath, ref artifacts, missingArtifacts);
        }

        foreach (var missingDependency in missingDependencies)
        {
            var parts = missingDependency.Split(':');

            // Missing dependency must be in format of groupdId:artifactId:version
            if (parts.Length != 3) continue;

            var existingArtifact = existingArtifacts.FirstOrDefault(
                    x => x.GroupId == parts[0] && x.ArtifactId == parts[1]
                );

            AddParentArtifact(
                existingArtifacts,
                parts[0], parts[1], parts[2],
                existingArtifact, parentArtifactIds, log,
                homeFolderPath, "compile", 0,
                basePath, ref artifacts, missingArtifacts);
        }


        artifact.ParentArtifacts = parentArtifactIds.ToArray();

        return artifacts;
    }

    private static void AddParentArtifact(
        List<ArtifactModel> existingArtifacts,
        string xgroupId,
        string xartifactId,
        string xversion,
        ArtifactModel existingArtifact,
        List<KeyValuePair<string, string>> parentArtifactIds,
        Action<string> log,
        string homeFolderPath,
        string scope,
        int nugetRevision,
        string basePath,
        ref List<ArtifactModel> artifacts,
        List<string> missingArtifacts = default)
    {
        SemanticVersion artifactVersion = SemanticVersion.TryParse(xversion, out var semanticVersion)
            ? semanticVersion
            : NuGetVersion.Parse(xversion);

        if (existingArtifact != null && artifactVersion != existingArtifact.Version)
        {
            parentArtifactIds.Add(new KeyValuePair<string, string>(existingArtifact.NugetPackageId, scope));
            log?.Invoke(
                $"ARTIFACT EXISTS >> {xgroupId}:{xartifactId}-{xversion} << {existingArtifact.Version}"
            );

            if (existingArtifact.Version < artifactVersion)
            {
                var (_, xartifactFiles) = GetArtifactFiles(
                    homeFolderPath,
                    xgroupId,
                    xartifactId,
                    artifactVersion
                );
                existingArtifact.Files = xartifactFiles;
                existingArtifact.Version = artifactVersion;
                existingArtifact.NugetVersion = artifactVersion.ToNuGetVersion(nugetRevision);
            }

            return;
        }

        var parentArtifact = FindExternalArtifact(basePath, xgroupId, xartifactId, artifactVersion);

        if (parentArtifact == null)
        {
            var parentArtifacts = Scan(
                existingArtifacts,
                basePath,
                xgroupId,
                xartifactId,
                artifactVersion,
                log,
                nugetRevision: nugetRevision,
                nugetPackageId: existingArtifact?.NugetPackageId,
                missingDependencies: existingArtifact?.MissingDependencies ?? Array.Empty<string>(),
                missingArtifacts: missingArtifacts);

            if (parentArtifacts.Count == 0) return;

            artifacts.AddRange(parentArtifacts);
            existingArtifacts.AddRange(parentArtifacts);
            artifacts = artifacts.Distinct().ToList();
            parentArtifactIds.Add(new KeyValuePair<string, string>(parentArtifacts[0].NugetPackageId, scope));
        }
        else
        {
            if (artifactVersion != parentArtifact.Version)
            {
                log?.Invoke(
                    $"EXTERNAL ARTIFACT >> {xgroupId}:{xartifactId}-{xversion} << {parentArtifact.Version}"
                );
            }

            artifacts.Add(parentArtifact);
            parentArtifactIds.Add(new KeyValuePair<string, string>(parentArtifact.NugetPackageId, scope));
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
        var artifactVersionFolderPath = Path.Combine(
            homeFolderPath,
            $".gradle/caches/modules-2/files-2.1/{groupId}/{artifactId}/{version}"
        );

        if (!Directory.Exists(artifactVersionFolderPath))
        {
            if (version.Patch == 0)
            {
                artifactVersionFolderPath = Path.Combine(
                    homeFolderPath,
                    $".gradle/caches/modules-2/files-2.1/{groupId}/{artifactId}/{version.Major}.{version.Minor}"
                );
            }

            if (!Directory.Exists(artifactVersionFolderPath))
            {
                return (artifactVersionFolderPath, Array.Empty<string>());
            }
        }

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

    private static ArtifactModel FindExternalArtifact(string basePath, string xgroupId, string xartifactId, SemanticVersion xversion)
    {
        var externalArtifactFolderPath = Path.Combine(
                basePath,
                "metadata", "android",
                xgroupId, xartifactId
            );

        if (!Directory.Exists(externalArtifactFolderPath)) return null;

        var nugetVersion = GetNugetVersion(externalArtifactFolderPath, xversion);

        if (nugetVersion == null) return null;

        var externalArtifactNugetPath = Path.Combine(
                externalArtifactFolderPath,
                "nuget.json"
            );
        using var stream = File.OpenRead(externalArtifactNugetPath);
        var nugetModel = stream.Deserialize<NugetModel>();

        return new ArtifactModel
        {
            GroupId = xgroupId,
            ArtifactId = xartifactId,
            Version = xversion,
            NugetPackageId = nugetModel.PackageId,
            NugetVersion = nugetVersion,
            DependencyOnly = true,
        };
    }

    private static NuGetVersion GetNugetVersion(string externalArtifactFolderPath, SemanticVersion xversion)
    {
        var externalArtifactVersionPath = Path.Combine(
                externalArtifactFolderPath,
                xversion + ".json"
            );

        if (!File.Exists(externalArtifactVersionPath)) return null;

        var artifactVersionModel = ReadArtifactVersionModel(externalArtifactVersionPath);

        if (artifactVersionModel.FallbackVersion != null)
        {
            return GetNugetVersion(externalArtifactFolderPath, artifactVersionModel.FallbackVersion);
        }

        return artifactVersionModel.NugetVersion ?? xversion.ToNuGetVersion(artifactVersionModel.Revision);
    }

    private static ArtifactVersionModel ReadArtifactVersionModel(string externalArtifactVersionPath)
    {
        using var stream = File.OpenRead(externalArtifactVersionPath);

        return stream.Deserialize<ArtifactVersionModel>();
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
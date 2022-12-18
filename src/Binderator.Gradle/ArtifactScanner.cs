using System.Collections.Generic;

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
        return Scan(new (), metadataBasePath, groupId, artifactId, NuGetVersion.Parse(version), log, missingArtifacts: new ());
    }

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
        List<string> missingArtifacts = default)
    {
        List<ArtifactModel> artifacts = new();
        missingArtifacts ??= new();
        var homeFolder = Platform.IsWindows
                    ? Environment.SpecialFolder.LocalApplicationData
                    : Environment.SpecialFolder.Personal;
        var homeFolderPath = Environment.GetFolderPath(homeFolder);
        var artifactVersionFolderPath = Path.Combine(
            homeFolderPath,
            $".gradle/caches/modules-2/files-2.1/{groupId}/{artifactId}/{version}"
        );

        if (!Directory.Exists(artifactVersionFolderPath))
        {
            log?.Invoke(
                $"ARTIFACT FOLDER MISSING >> {groupId}:{artifactId}-{version} << {artifactVersionFolderPath}"
            );
            missingArtifacts.Add($"{groupId}:{artifactId}-{version} << {artifactVersionFolderPath}");

            return artifacts;
        }

        var files = Directory.GetFiles(
            artifactVersionFolderPath,
            "*.*",
            SearchOption.AllDirectories
        );

        var artifact = new ArtifactModel
        {
            GroupId = groupId,
            GroupName = groupName,
            ArtifactId = artifactId,
            ArtifactName = artifactName,
            Version = version,
            NugetVersion = version.ToNuGetVersion(nugetRevision),
            NugetPackageId = CreateNugetId(groupId, artifactId),
            Files = files
                .Where(x => !x.Contains("/_aar/"))
                .Select(x => x.Replace(homeFolderPath, string.Empty).Trim('/'))
                .ToArray(),
            Tags = tags,
        };

        var artifactPomFileName = $"{artifactId}-{version}.pom";
        var pomFilePath = files.FirstOrDefault(x => x.EndsWith(artifactPomFileName));

        if (pomFilePath == null)
        {
            var libFilePath = files.FirstOrDefault(x =>
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
        xmlDocument.Load(pomFilePath);

        // Add the namespace.  
        XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDocument.NameTable);
        nsmgr.AddNamespace("mvn", "http://maven.apache.org/POM/4.0.0");

        artifact.Packaging = xmlDocument.DocumentElement.SelectSingleNode("descendant::mvn:packaging", nsmgr)?.InnerText;
        artifacts.Add(artifact);

        var dependencies = xmlDocument.DocumentElement.SelectNodes("mvn:dependencies/mvn:dependency", nsmgr);

        var parentArtifactIds = new List<KeyValuePair<string, string>>();
        foreach (XmlNode dependency in dependencies)
        {
            var scope = dependency.SelectSingleNode("descendant::mvn:scope", nsmgr).InnerText;
            if (scope == "test") continue;            

            var xgroupId = dependency.SelectSingleNode("descendant::mvn:groupId", nsmgr).InnerText;
            var xartifactId = dependency.SelectSingleNode("descendant::mvn:artifactId", nsmgr).InnerText;
            var existingArtifact = existingArtifacts.FirstOrDefault(
                x => x.GroupId == xgroupId && x.ArtifactId == xartifactId
            );

            var xversion = dependency.SelectSingleNode("descendant::mvn:version", nsmgr)?.InnerText;

            // TODO Handle strict version
            var artifactVersion = SemanticVersion.Parse(xversion.Trim('[', ']'));

            if (existingArtifact != null && artifactVersion != existingArtifact.Version)
            {
                parentArtifactIds.Add(new KeyValuePair<string, string>(existingArtifact.NugetPackageId, scope));
                log?.Invoke(
                    $"ARTIFACT EXISTS >> {xgroupId}:{xartifactId}-{xversion} << {existingArtifact.Version}"
                );

                if (existingArtifact.Version < artifactVersion)
                {
                    existingArtifact.Version = artifactVersion;
                }

                continue;
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
                    missingArtifacts: missingArtifacts);

                if (parentArtifacts.Count == 0) continue;

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
        artifact.ParentArtifacts = parentArtifactIds.ToArray();

        return artifacts;
    }

    private static ArtifactModel FindExternalArtifact(string basePath, string xgroupId, string xartifactId, SemanticVersion xversion)
    {
        var externalArtifactFolderPath = System.IO.Path.Combine(
                basePath,
                "metadata", "android",
                xgroupId, xartifactId
            );

        if (!System.IO.Directory.Exists(externalArtifactFolderPath)) return null;

        var nugetVersion = GetNugetVersion(externalArtifactFolderPath, xversion);

        if (nugetVersion == null) return null;

        var externalArtifactNugetPath = System.IO.Path.Combine(
                externalArtifactFolderPath,
                "nuget.json"
            );
        using var stream = System.IO.File.OpenRead(externalArtifactNugetPath);
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
        var externalArtifactVersionPath = System.IO.Path.Combine(
                externalArtifactFolderPath,
                xversion + ".json"
            );

        if (!System.IO.File.Exists(externalArtifactVersionPath)) return null;
        
        var artifactVersionModel = ReadArtifactVersionModel(externalArtifactVersionPath);

        if (artifactVersionModel.FallbackVersion != null)
        {
            return GetNugetVersion(externalArtifactFolderPath, artifactVersionModel.FallbackVersion);
        }

        return xversion.ToNuGetVersion();
    }

    private static ArtifactVersionModel ReadArtifactVersionModel(string externalArtifactVersionPath)
    {
        using var stream = System.IO.File.OpenRead(externalArtifactVersionPath);

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
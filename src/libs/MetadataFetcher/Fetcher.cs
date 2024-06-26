using NuGet.Versioning;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

public static class Fetcher
{
    static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        AllowTrailingCommas = true,
        Converters = {
            new JsonStringEnumConverter(),
            new NuGetVersionConverter(),
        },
        WriteIndented = true,
    };

    public static string BasePath = ".";

    public static Task FetchWithFileAsync(string nugetJsonPath)
    {
        var nugetInfo = Read(nugetJsonPath);
        var fileParts = nugetJsonPath
            .Replace(BasePath, string.Empty)
            .Trim(Path.DirectorySeparatorChar)
            .Split(Path.DirectorySeparatorChar)
            .ToArray();
        Console.WriteLine("{0} -> {1}:{2}", nugetInfo.PackageId, fileParts[^3], fileParts[^2], fileParts[^4]);
        return FetchAsync(nugetInfo.PackageId, fileParts[^3], fileParts[^2], fileParts[^4]);
    }

    public static async Task FetchAsync(
        string packageId,
        string groupId,
        string artifactId,
        string platform,
        Action<string, string> log = null)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(@$"
--nupkg-id      =   {packageId}
--group-id      =   {groupId}
--artifact-id   =   {artifactId}
--platform      =   {platform}
        ");

        var httpClient = new HttpClient();
        var encodedPackageId = System.Net.WebUtility.UrlEncode(packageId);
        var url = $"https://api.nuget.org/v3-flatcontainer/{encodedPackageId}/index.json";
        string json = "{}";

        await httpClient.GetStringAsync(url)
            .ContinueWith(t =>
            {
                json = t.IsCompletedSuccessfully ? t.Result : json;
            });

        var data = JsonSerializer.Deserialize<MetadataDto>(
            json,
            jsonSerializerOptions
        );

        if (data?.Versions is null
            || data?.Versions?.Length <= 0)
        {
            log?.Invoke(packageId, "No versions found for given package ID");
            return;
        }

        var versionGroups = data.Versions
            .Select(x => NuGet.Versioning.NuGetVersion.Parse(x))
            .GroupBy(x => (x.Major, x.Minor, x.Patch, x.Release))
            .ToList();

        var folderPath = Path
            .Combine(BasePath, platform, groupId, artifactId)
            .ToLower();

        var nugetInfo = GetAndSaveNugetInfo(folderPath, packageId);

        foreach (var vg in versionGroups)
        {
            var latestVersion = vg.Last();

            string artifactVersion = null;
            string nugetVersion = null;
            if (nugetInfo.VersionMappings?.Length > 0)
            {
                foreach (var versionMapping in nugetInfo.VersionMappings)
                {
                    if (versionMapping.FromVersion != null && versionMapping.FromVersion > latestVersion ||
                         versionMapping.ToVersion != null && versionMapping.ToVersion <= latestVersion)
                        continue;

                    switch (versionMapping.Method)
                    {
                        case VersionMappingMethod.Prefix:
                            artifactVersion = $"{(latestVersion.Major.ToString().Substring(versionMapping.Prefix.Length))}.{latestVersion.Minor}.{latestVersion.Patch}";
                            nugetVersion = latestVersion.ToNormalizedString();
                            break;
                        case VersionMappingMethod.CombinedToMinor:
                            var combinedVersion = latestVersion.Minor.ToString();
                            artifactVersion = $"{combinedVersion.Substring(0, combinedVersion.Length - 2)}.{combinedVersion.Substring(combinedVersion.Length - 2, 1)}.{combinedVersion.Substring(combinedVersion.Length - 1)}";
                            nugetVersion = latestVersion.ToNormalizedString();
                            break;
                    }
                }

                if (string.IsNullOrWhiteSpace(artifactVersion)) continue;
            }
            else
            {
                artifactVersion = $"{latestVersion.Major}.{latestVersion.Minor}.{latestVersion.Patch}";
            }

            if (!string.IsNullOrEmpty(latestVersion.Release))
            {
                artifactVersion += $"-{latestVersion.Release}";
            }

            var artifactVersionPath = Path.Combine(
                folderPath,
                artifactVersion + ".json"
            );
            VersionDto? version = File.Exists(artifactVersionPath) 
                ? JsonSerializer.Deserialize<VersionDto>(
                    File.ReadAllText(artifactVersionPath),
                    jsonSerializerOptions)
                : new VersionDto();
            version.Revision = latestVersion.Revision;
            version.NugetVersion = string.IsNullOrWhiteSpace(nugetVersion)
                ? null
                : NuGetVersion.Parse(nugetVersion);

            var artifactVersionMetadataInJson = JsonSerializer.Serialize(
                version,
                jsonSerializerOptions);

            File.WriteAllText(artifactVersionPath, artifactVersionMetadataInJson);
        }
    }

    private static NugetInfoDto GetAndSaveNugetInfo(string folderPath, string packageId)
    {
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        var nugetMetadataPath = Path.Combine(folderPath, "nuget.json");

        var nugetInfo = Read(nugetMetadataPath) ?? new NugetInfoDto();
        nugetInfo.PackageId = packageId;
        nugetInfo.DependencyOnly = true;
        var nugetMetadataInJSON = JsonSerializer.Serialize(
            nugetInfo,
            jsonSerializerOptions);
        File.WriteAllText(nugetMetadataPath, nugetMetadataInJSON);
        return nugetInfo;
    }

    private static NugetInfoDto Read(string jsonPath)
    {
        if (File.Exists(jsonPath))
        {
            var infoInJson = File.ReadAllText(jsonPath);
            return JsonSerializer.Deserialize<NugetInfoDto>(
                infoInJson,
                jsonSerializerOptions
            );
        }
        return null;
    }
}
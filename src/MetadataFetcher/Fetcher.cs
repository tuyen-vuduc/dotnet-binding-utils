using System.Text.Json;
using System.Text.Json.Serialization;

public static class Fetcher
{
    public static string BasePath = ".";

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
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            }
        );

        if (data?.Versions?.Length <= 0)
        {
            log?.Invoke(packageId, "No versions found for given package ID");
            return;
        }

        var versionGroups = data.Versions
            .Select(x => NuGet.Versioning.NuGetVersion.Parse(x))
            .GroupBy(x => (x.Major, x.Minor, x.Patch, x.Release))
            .ToList();

        foreach (var vg in versionGroups)
        {
            var latestVersion = vg.Last();

            var folderPath = Path
                .Combine(BasePath, "metadata", platform, groupId, artifactId)
                .ToLower();

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var nugetMetadataPath = Path.Combine(folderPath, "nuget.json");

            var nugetInfo = new NugetInfoDto()
            {
                PackageId = packageId,
            };
            if (!File.Exists(nugetMetadataPath))
            {
                var nugetMetadataInJSON = JsonSerializer.Serialize(nugetInfo);
                File.WriteAllText(nugetMetadataPath, nugetMetadataInJSON);
            }
            else
            {
                var infoInJson = File.ReadAllText(nugetMetadataPath);
                nugetInfo = JsonSerializer.Deserialize<NugetInfoDto>(
                    infoInJson,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        Converters = {
                            new JsonStringEnumConverter(),
                            new NuGetVersionConverter(),
                        },
                    }
                );
            }

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

                if (string.IsNullOrWhiteSpace(artifactVersion)) return;
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
            var artifactVersionMetadataInJson = JsonSerializer.Serialize(new
            {
                revision = latestVersion.Revision,
                nugetVersion = nugetVersion,
            });
            File.WriteAllText(artifactVersionPath, artifactVersionMetadataInJson);
        }
    }
}
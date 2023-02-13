using System.Text.Json;

public static class Fetcher 
{
    public static string BasePath = ".";

    public static async Task FetchAsync(
        string packageId, 
        string groupId, 
        string artifactId,
        string platform,
        Action<string, string> log = null) {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(@$"
--nupkg-id      =   {packageId}
--group-id      =   {groupId}
--artifact-id   =   {artifactId}
--platform      =   {platform}
        ");

        var httpClient = new HttpClient();
        var encodedPackageId = System.Net.WebUtility.UrlEncode(packageId);
        var url=$"https://api.nuget.org/v3-flatcontainer/{encodedPackageId}/index.json";
        string json = "{}";

        await httpClient.GetStringAsync(url)
            .ContinueWith(t => {
                json = t.IsCompletedSuccessfully ? t.Result : json;
            });

        var data = JsonSerializer.Deserialize<MetadataDto>(
            json,
            new JsonSerializerOptions {
                PropertyNameCaseInsensitive = true,
            }
        );

        if (data?.Versions?.Length <= 0) {
            log?.Invoke(packageId, "No versions found for given package ID");
            return;
        }

        var versionGroups = data.Versions
            .Select(x => NuGet.Versioning.NuGetVersion.Parse(x))
            .GroupBy(x => (x.Major, x.Minor, x.Patch, x.Release))
            .ToList();

        foreach (var vg in versionGroups) {
            var latestVersion = vg.Last();

            var folderPath = Path
                .Combine(BasePath, "metadata", platform, groupId, artifactId)
                .ToLower();

            if (!Directory.Exists(folderPath)) {
                Directory.CreateDirectory(folderPath);
            }

            var nugetMetadataPath = Path.Combine(folderPath, "nuget.json");

            if (!File.Exists(nugetMetadataPath)) {
                var nugetMetadataInJSON = JsonSerializer.Serialize(new {
                    packageId,
                });
                File.WriteAllText(nugetMetadataPath, nugetMetadataInJSON);
            }

            var artifactVersion = $"{latestVersion.Major}.{latestVersion.Minor}.{latestVersion.Patch}";
            if (!string.IsNullOrEmpty(latestVersion.Release)) {
                artifactVersion += $"-{latestVersion.Release}";
            }

            var artifactVersionPath = Path.Combine(
                folderPath,
                artifactVersion + ".json"
            );
            var artifactVersionMetadataInJson = JsonSerializer.Serialize(new
            {
                revision = latestVersion.Revision,
            });
            File.WriteAllText(artifactVersionPath, artifactVersionMetadataInJson);
        }
    }
}
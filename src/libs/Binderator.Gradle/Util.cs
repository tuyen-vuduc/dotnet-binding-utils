using System.Text;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace Binderator.Gradle;

public static class Util
{
    static readonly JsonSerializerOptions jsonSerializerOptions = new ()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        IgnoreNullValues = true,
    };

    public readonly static JsonSerializerOptions JsonOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters =
            {
                new NuGetVersionJsonValueConverter(),
                new SemanticVersionJsonValueConverter(),
            }
    };

    public static T Deserialize<T>(this Stream stream)
        => JsonSerializer.Deserialize<T>(stream, JsonOptions);

    public static string Serialize<T>(this T obj)
        => JsonSerializer.Serialize(obj, JsonOptions);

    internal static string HashMd5(Stream value)
    {
        using (var md5 = MD5.Create())
            return BitConverter.ToString(md5.ComputeHash(value)).Replace("-", "").ToLowerInvariant();
    }

    internal static string HashSha256(string value)
    {
        return HashSha256(Encoding.UTF8.GetBytes(value));
    }

    internal static string HashSha256(byte[] value)
    {
        using (var sha256 = new SHA256Managed())
        {
            var hash = new StringBuilder();
            var hashData = sha256.ComputeHash(value);
            foreach (var b in hashData)
                hash.Append(b.ToString("x2"));

            return hash.ToString();
        }
    }

    internal static string HashSha256(Stream value)
    {
        using (var sha256 = new SHA256Managed())
        {
            var hash = new StringBuilder();
            var hashData = sha256.ComputeHash(value);
            foreach (var b in hashData)
                hash.Append(b.ToString("x2"));

            return hash.ToString();
        }
    }
    public static ArtifactModel FromArtifactString(string basePath, string artifactString)
    {
        var artifactParts = artifactString.Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

        if (artifactParts.Length != 3)
        {
            throw new InvalidOperationException("You must provide a valid artifact string, e.g. group:artifact:version");
        }

        GroupModel group = FetchGroupInfo(basePath, artifactParts[0]);
        NuGetModel nuget = FetchNugetInfo(basePath, artifactParts[0], artifactParts[1]);
        VersionModel version = FetchVersionInfo(basePath, artifactParts[0], artifactParts[1], artifactParts[2]);

        return new()
        {
            Group = group,
            Nuget = nuget,
            Version = version,
        };

    }
    private static VersionModel FetchVersionInfo(string basePath, string groupId, string artifactId, string versionString)
    {
        if (!SemanticVersion.TryParse(versionString, out var semanticVersion))
        {
            throw new InvalidOperationException("You must provide a valid version string.");
        }

        var versionJsonPath = Path.Combine(basePath, "src", "android", groupId, artifactId, $"{semanticVersion.ToNormalizedString()}.json");
        VersionModel version;
        if (File.Exists(versionJsonPath))
        {
            version = JsonSerializer.Deserialize<VersionModel>(
                File.ReadAllText(versionJsonPath),
                jsonSerializerOptions
            );
        }
        else
        {
            version = new VersionModel
            {
                NugetVersion = semanticVersion.ToNuGetVersion(),
                Revision = 0,
                FallbackVersion = null,
            };
        }
        version.SemanticVersion = semanticVersion;

        File.WriteAllText(versionJsonPath, JsonSerializer.Serialize(version, jsonSerializerOptions));
        return version;
    }

    private static NuGetModel FetchNugetInfo(string basePath, string groupId, string artifactId)
    {
        var artifactFolderPath = Path.Combine(basePath, "src", "android", groupId, artifactId);

        if (!Directory.Exists(artifactFolderPath))
        {
            Directory.CreateDirectory(artifactFolderPath);
        }

        NuGetModel nuget;

        var nugetJsonPath = Path.Combine(artifactFolderPath, "nuget.json");
        if (File.Exists(nugetJsonPath))
        {
            nuget = JsonSerializer.Deserialize<NuGetModel>(
                File.ReadAllText(nugetJsonPath),
                jsonSerializerOptions
            );
            nuget.ArtifactId = artifactId;
            nuget.Name = string.IsNullOrWhiteSpace(nuget.Name)
                ? artifactId
                : nuget.Name;
        }
        else
        {
            nuget = new NuGetModel
            {
                ArtifactId = artifactId,
                Name = artifactId,
            };
        }

        var iconFile = nuget.Icon ?? "icon.png";
        var iconPath = Path.Combine(artifactFolderPath, iconFile);
        if (File.Exists(iconPath))
        {
            nuget.Icon = iconFile;
        }

        File.WriteAllText(nugetJsonPath, JsonSerializer.Serialize(nuget, jsonSerializerOptions));
        return nuget;
    }

    private static GroupModel FetchGroupInfo(string basePath, string groupId)
    {
        var groupFolderPath = Path.Combine(basePath, "src", "android", groupId);

        if (!Directory.Exists(groupFolderPath))
        {
            Directory.CreateDirectory(groupFolderPath);
        }

        GroupModel group;

        var groupJsonPath = Path.Combine(groupFolderPath, "group.json");
        if (File.Exists(groupJsonPath))
        {
            group = JsonSerializer.Deserialize<GroupModel>(
                File.ReadAllText(groupJsonPath),
                jsonSerializerOptions
            );
            group.Id = groupId;
            group.Name = string.IsNullOrWhiteSpace(group.Name)
                ? groupId
                : group.Name;
        }
        else
        {
            group = new GroupModel
            {
                Id = groupId,
                Name = groupId,
            };
        }

        var iconFile = group.Icon ?? "icon.png";
        var iconPath = Path.Combine(groupFolderPath, iconFile);
        if (File.Exists(iconPath))
        {
            group.Icon = iconFile;
        }

        File.WriteAllText(groupJsonPath, JsonSerializer.Serialize(group, jsonSerializerOptions));
        return group;
    }

}

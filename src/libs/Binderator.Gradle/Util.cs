using System.Text;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace Binderator.Gradle;

public static class Util
{
    static readonly JsonSerializerOptions jsonSerializerOptions = new ()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        AllowTrailingCommas = true,
        Converters = {
            new JsonStringEnumConverter(),
            new NuGetVersionConverter(),
            new SemanticVersionConverter(),
        },
        WriteIndented = true,
    };

    public static T Deserialize<T>(this Stream stream)
        => JsonSerializer.Deserialize<T>(stream, jsonSerializerOptions);

    public static string Serialize<T>(this T obj)
        => JsonSerializer.Serialize(obj, jsonSerializerOptions);

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
    public static ArtifactModel FromArtifactString(string basePath, string artifactString, bool overriding)
    {
        var artifactParts = artifactString.Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

        if (artifactParts.Length != 3)
        {
            throw new InvalidOperationException("You must provide a valid artifact string, e.g. group:artifact:version");
        }

        GroupModel group = FetchGroupInfo(basePath, artifactParts[0], overriding);
        NuGetModel nuget = FetchNugetInfo(basePath, artifactParts[0], artifactParts[1], overriding);
        VersionModel version = FetchVersionInfo(basePath, artifactParts[0], artifactParts[1], artifactParts[2], overriding);

        return new()
        {
            Group = group,
            Nuget = nuget,
            Version = version,
        };

    }
    private static VersionModel FetchVersionInfo(string basePath, string groupId, string artifactId, string versionString, bool overriding = false)
    {
        if (!SemanticVersion.TryParse(versionString, out var semanticVersion))
        {
            throw new InvalidOperationException("You must provide a valid version string.");
        }

        var versionJsonPath = Path.Combine(basePath, "src", "android", groupId, artifactId, $"{semanticVersion.ToNormalizedString()}.json");
        VersionModel version = null;
        if (File.Exists(versionJsonPath))
        {
            version = JsonSerializer.Deserialize<VersionModel>(
                File.ReadAllText(versionJsonPath),
                jsonSerializerOptions
            );
        }
        else if (overriding)
        {
            version = new VersionModel
            {
                Revision = 0,
                FallbackVersion = null,
            };
        }

        if (version is not null)
        {
            version.SemanticVersion = semanticVersion;

            if (version.NugetVersion is null)
            {
                version.NugetVersion = semanticVersion.ToNuGetVersion(version.Revision);
            }
        }

        if (overriding)
        {
            File.WriteAllText(versionJsonPath, JsonSerializer.Serialize(version, jsonSerializerOptions));
        }
        return version;
    }

    private static NuGetModel FetchNugetInfo(string basePath, string groupId, string artifactId, bool overriding = false)
    {
        var artifactFolderPath = Path.Combine(basePath, "src", "android", groupId, artifactId);

        overriding |= Directory.Exists(artifactFolderPath);

        if (overriding)
        {
            Directory.CreateDirectory(artifactFolderPath);
        }

        NuGetModel nuget = null;

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
        else if (overriding)
        {
            nuget = new NuGetModel
            {
                ArtifactId = artifactId,
                Name = artifactId,
            };
        }

        if (nuget is not null)
        {
            var iconPath = Path.Combine(artifactFolderPath, "icon.png");
            if (File.Exists(iconPath))
            {
                nuget.Icon = iconPath;
            }
            nuget.PackageId ??= CreateNugetId(groupId, artifactId);
        }

        if (overriding)
        {
            File.WriteAllText(nugetJsonPath, JsonSerializer.Serialize(nuget, jsonSerializerOptions));
        }
        return nuget;
    }

    private static GroupModel FetchGroupInfo(string basePath, string groupId, bool overriding = false)
    {
        var groupFolderPath = Path.Combine(basePath, "src", "android", groupId);

        overriding |= Directory.Exists(groupFolderPath);

        if (overriding)
        {
            Directory.CreateDirectory(groupFolderPath);
        }

        GroupModel group = null;

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
        else if (overriding)
        {
            group = new GroupModel
            {
                Id = groupId,
                Name = groupId,
            };
        }

        if (group is not null)
        {
            var iconPath = Path.Combine(groupFolderPath, "icon.png");
            if (File.Exists(iconPath))
            {
                group.Icon = iconPath;
            }
            var mavenPropsPath = Path.Combine(groupFolderPath, "maven.props");
            if (File.Exists(mavenPropsPath))
            {
                group.MavenPropsFile = mavenPropsPath;
            }
        }

        if (overriding)
        {
            File.WriteAllText(groupJsonPath, JsonSerializer.Serialize(group, jsonSerializerOptions));
        }
        return group;
    }

    static string CreateNugetId(string groupId, string artifactId)
    {
        return string.Join(
                ".",
                groupId.Split('.')
                    .Select(x => x.ToCSharpName())
                ) + "." + artifactId.ToCSharpName();
    }

    class NuGetVersionConverter : JsonConverter<NuGetVersion>
    {
        public override NuGetVersion? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var stringValue = reader.GetString();
            return NuGetVersion.TryParse(stringValue, out var result)
                ? result
                : null;
        }

        public override void Write(Utf8JsonWriter writer, NuGetVersion value, JsonSerializerOptions options)
        {
            var stringValue = value?.ToNormalizedString();
            writer.WriteStringValue(stringValue);
        }
    }
    class SemanticVersionConverter : JsonConverter<SemanticVersion>
    {
        public override SemanticVersion? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var stringValue = reader.GetString();
            return SemanticVersion.TryParse(stringValue, out var result)
                ? result
                : null;
        }

        public override void Write(Utf8JsonWriter writer, SemanticVersion value, JsonSerializerOptions options)
        {
            var stringValue = value?.ToNormalizedString();
            writer.WriteStringValue(stringValue);
        }
    }
}

using System.Text;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace Binderator.Gradle;

public static class Util
{
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
}

using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.Text.Json.Serialization;
using NuGet.Versioning;

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
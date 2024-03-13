namespace Binderator.Gradle;

public class NuGetVersionJsonValueConverter : System.Text.Json.Serialization.JsonConverter<NuGetVersion>
{
    public override NuGetVersion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var versionString = reader.GetString();
        return NuGetVersion.TryParse(versionString, out var result)
            ? result
            : null;
    }

    public override void Write(Utf8JsonWriter writer, NuGetVersion value, JsonSerializerOptions options)
    {
        var versionString = value.ToNormalizedString();
        writer.WriteStringValue(versionString);
    }
}

public class SemanticVersionJsonValueConverter : System.Text.Json.Serialization.JsonConverter<SemanticVersion>
{
    public override SemanticVersion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var versionString = reader.GetString();
        return SemanticVersion.TryParse(versionString, out var result)
            ? result
            : null;
    }

    public override void Write(Utf8JsonWriter writer, SemanticVersion value, JsonSerializerOptions options)
    {
        var versionString = value.ToNormalizedString();
        writer.WriteStringValue(versionString);
    }
}


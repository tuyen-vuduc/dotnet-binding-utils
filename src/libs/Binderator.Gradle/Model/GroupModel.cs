using System.Text.Json.Serialization;

namespace Binderator.Gradle;

public record GroupModel
{
    [JsonIgnore]
    public string Id { get; set; }
    public string Name { get; set; }
    public string HomePageUrl { get; set; }
    public string GuideUrl { get; set; }
    public bool Dotnet8 { get; set; } = false;
    [JsonIgnore]
    public string Icon { get; set; }
    [JsonIgnore]
    public string MavenPropsFile { get; set; }
    public bool? RuntimeDependenciesAsCompile { get; set; } = true;
}

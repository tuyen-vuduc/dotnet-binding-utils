using System.Text.Json.Serialization;

namespace Binderator.Gradle;

public record NuGetModel
{
    [JsonIgnore]
    public string ArtifactId { get; set; }
    public string PackageId { get; set; }
    public string Name { get; set; }
    public string HomePageUrl { get; set; }
    public string GuideUrl { get; set; }
    public string Icon { get; set; }
    public IEnumerable<VersionMappingModel> VersionMappings { get; set; } = new VersionMappingModel[0];
}

public record VersionMappingModel
{
    public string Prefix { get; set; }
    public string Method { get; set; }
    public SemanticVersion FromVersion { get; set; }
    public SemanticVersion ToVersion { get; set; }
}
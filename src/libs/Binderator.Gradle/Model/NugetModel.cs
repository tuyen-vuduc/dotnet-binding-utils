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
    public string Relocated { get; set; }
    public bool DependencyOnly { get; set; }
    public bool Dotnet8 { get; set; } = true;
    [JsonIgnore]
    public string Icon { get; set; }
    public IEnumerable<VersionMappingModel> VersionMappings { get; set; } = [];
}

public record VersionMappingModel
{
    public string Prefix { get; set; }
    public VersionMappingMethod Method { get; set; }
    public NuGetVersion FromVersion { get; set; }
    public NuGetVersion ToVersion { get; set; }
}

public enum VersionMappingMethod
{
    Prefix,
    CombinedToMinor,
}
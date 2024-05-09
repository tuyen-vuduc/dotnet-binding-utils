using System.Text.Json.Serialization;

namespace Binderator.Gradle;

public record VersionModel
{
    [JsonIgnore]
    public SemanticVersion SemanticVersion { get; set; }
    public int Revision { get; set; }
    public SemanticVersion FallbackVersion { get; set; }
    public NuGetVersion NugetVersion { get; set; }
    public bool? WithoutPatch { get; set; }
    public bool? RuntimeDependenciesAsCompile { get; set; }
    public bool? UseMyGet { get; set; }
}
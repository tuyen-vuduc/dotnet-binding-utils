namespace Binderator.Gradle;

public class ArtifactVersionModel
{
    public int Revision { get; set; }
    public SemanticVersion FallbackVersion { get; set; }
    public NuGetVersion NugetVersion { get; set; }
}


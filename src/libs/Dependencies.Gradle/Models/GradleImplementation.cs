using System;
namespace Dependencies.Gradle;

public record class GradleImplementation
{
    public string Id { get; set; }

    public string GroupName { get; set; }
    public string ArtifactName { get; set; }
    public string Version { get; set; }

    public string Implemetation { get; set; }
}
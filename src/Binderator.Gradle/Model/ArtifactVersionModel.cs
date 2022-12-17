using System;
namespace Binderator.Gradle;

public class ArtifactVersionModel
{
    public int Revision { get; set; }
    public string FallbackVersion { get; set; }
}


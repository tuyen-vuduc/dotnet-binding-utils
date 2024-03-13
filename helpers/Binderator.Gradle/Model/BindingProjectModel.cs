using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Binderator.Gradle;

public class BindingProjectModel
{
	public string Id { get; private set; } = Guid.NewGuid().ToString().ToUpperInvariant();

    public ArtifactModel Artifact { get; set; }

    public string GroupName => string.IsNullOrWhiteSpace(Artifact.GroupName)
        ? string.IsNullOrWhiteSpace(Config.GroupName)
        ? Artifact.GroupId
        : Config.GroupName
        : Artifact.GroupName;

    public string ArtifactName => string.IsNullOrWhiteSpace(Artifact.ArtifactName)
        ? Artifact.ArtifactId
        : Artifact.ArtifactName;

    public string Tags => string.Join(
        ",",
        new List<string>(
            Artifact.Tags ?? new string[0]
        ).Union(
            Config.Tags ?? new string[0]
        )
    );

	public List<ArtifactModel> NuGetDependencies { get; set; } = new List<ArtifactModel>();

	public List<string> ProjectReferences { get; set; } = new List<string>();

	public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();

	public BindingConfig Config { get; set; }
}

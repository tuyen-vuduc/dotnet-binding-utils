using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Binderator.Gradle;

public class BindingProjectModel
{
	public string Id { get; private set; } = Guid.NewGuid().ToString().ToUpperInvariant();

    public ArtifactModel Artifact { get; set; }

    public string GroupName => string.IsNullOrWhiteSpace(Artifact.Group.Name)
        ? Artifact.Group.Id
        : Artifact.Group.Name;

    public string ArtifactName => string.IsNullOrWhiteSpace(Artifact.Nuget.Name)
        ? Artifact.Nuget.ArtifactId
        : Artifact.Nuget.Name;

	public List<ArtifactModel> NuGetDependencies { get; set; } = new List<ArtifactModel>();

	public List<string> ProjectReferences { get; set; } = new List<string>();

	public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();

	public BindingConfig Config { get; set; }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Gradle.Binderator;

public class BindingProjectModel
{
	public string Id { get; private set; } = Guid.NewGuid().ToString().ToUpperInvariant();

    public ArtifactModel ArtifactConfig { get; set; }

    public string Key => ArtifactConfig?.Key;
    public string GradleImplenetation => ArtifactConfig.GradleImplenetation;

    public string LibRelativePath => ArtifactConfig.LibRelativePath;
    public string NugetPackageId => ArtifactConfig.NugetPackageId;
    public string ArtifactId => ArtifactConfig.ArtifactId;

    public string NugetVersionSuffix { get; set; }

	public string NugetVersion =>
		string.IsNullOrWhiteSpace(NugetVersionSuffix)
			? ArtifactConfig.NugetVersion
            : ArtifactConfig.NugetVersion + NugetVersionSuffix;

	public List<ArtifactModel> NuGetDependencies { get; set; } = new List<ArtifactModel>();

	public List<string> ProjectReferences { get; set; } = new List<string>();

	public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();

	public BindingConfig Config { get; set; }
}

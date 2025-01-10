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

    public List<KeyValuePair<string, string>> PackageReferences {
        get {
            var nugets = NuGetDependencies
                .Where(x => x.Nuget.DependencyOnly)
                .Select(
                    x => new KeyValuePair<string, string>(
                        x.Nuget.PackageId,
                        x.Version.NugetVersion.ToNormalizedString()
                    )
                )
                .Union(Artifact.FixedVersions)
                .GroupBy(x => x.Key)
                .Select(
                    x => new KeyValuePair<string, string>(
                        x.Key,
                        x.Select(v => NuGetVersion.Parse(v.Value))
                            .OrderByDescending(v => v)
                            .First()
                            .ToNormalizedString()
                    )
                )
                .ToList();

            return nugets;
        }
    }

    public List<string> ProjectReferences { get; set; } = new List<string>();

	public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();

	public BindingConfig Config { get; set; }
}

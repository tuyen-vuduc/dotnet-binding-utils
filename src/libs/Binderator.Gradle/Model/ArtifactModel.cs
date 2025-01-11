namespace Binderator.Gradle;

public class ArtifactModel : IEquatable<ArtifactModel>
{
    public string Name => string.IsNullOrWhiteSpace(Nuget.Name)
        ? Nuget.ArtifactId
        : Nuget.Name;
    public GroupModel Group { get; set; }
    public NuGetModel Nuget { get; set; }
    public VersionModel Version { get; set; }
    public string Icon => string.IsNullOrWhiteSpace(Nuget.Icon)
        ? Group.Icon
        : Nuget.Icon;
    public string AssemblyVersion => $"{
        Version.SemanticVersion.Major}.{
        Version.SemanticVersion.Minor}.{
        Version.SemanticVersion.Patch}.{
        DateTime.Today.DayOfYear}{
        DateTime.Now.TimeOfDay.Hours:D2}";
    public string InformationalVersion => $"{
        Version.NugetVersion}-{
        DateTime.Today.DayOfYear}{
        DateTime.Now.TimeOfDay.Hours:D2}";
    public string RepositoryUrl => $"https://github.com/tuyen-vuduc/dotnet-binding-utils/tree/main/src/android/{Group.Id}/{Nuget.ArtifactId}";
    public string Packaging { get; set; }
    public string[] Files { get; set; }

    public string Key => $"{Group.Id}:{Nuget.ArtifactId}";
    public string GradleImplementation => $"{Key}:{(Version.WithoutPatch == true ? $"{Version.SemanticVersion.Major}.{Version.SemanticVersion.Minor}" : Version.SemanticVersion)}";
    public string RelativeFolderPath => Path.Combine("src", "android", Group.Id, Nuget.ArtifactId);
    public string RelativeGroupFolderPath => Path.Combine("src", "android", Group.Id);
    public string RelativeBindingFolderPath => Path.Combine(RelativeFolderPath, "binding");

    public bool IsAAR => ShadowArtifact != null
        ? ShadowArtifact.IsAAR
        : Packaging == "aar" || Files?.Any(x => x.EndsWith(".aar")) == true;
    public string LibRelativePath => ShadowArtifact != null
        ? ShadowArtifact.LibRelativePath
        : IsAAR
        ? Files?.FirstOrDefault(x => !x.Contains("_aar") && x.EndsWith(".aar"))?.Replace("\\", "/")
        : Files?.FirstOrDefault(
            x => !x.Contains("_aar") 
            && !x.Contains("-sources") 
            && !x.Contains("-javadoc") 
            && x.EndsWith(".jar"))
        ?.Replace("\\", "/");
    public string SourcesJarRelativeFilePath => ShadowArtifact != null
        ? ShadowArtifact.SourcesJarRelativeFilePath
        : Files?.FirstOrDefault(x => x.EndsWith("-sources.jar"));
    public string JavadocJarRelativeFilePath => ShadowArtifact != null
        ? ShadowArtifact.JavadocJarRelativeFilePath
        : Files?.FirstOrDefault(x => x.EndsWith("-javadoc.jar"));
    public string LibFolderPath => ShadowArtifact != null
            ? ShadowArtifact.LibFolderPath
            : string.IsNullOrWhiteSpace(LibRelativePath)
            ? string.Empty
            : Path.GetDirectoryName(LibRelativePath)
        .Trim('/').Replace("\\", "/");
    public string ProguardFileRelativePath => ShadowArtifact != null
        ? ShadowArtifact.ProguardFileRelativePath
        : IsAAR
        ? Path.Combine(
            LibFolderPath ?? string.Empty,
            "_aar",
            "proguard.txt"
        ).Replace("\\", "/")
        : string.Empty;

    private KeyValuePair<string, string>[] parentArtifacts = [];
    public KeyValuePair<string, string>[] ParentArtifacts
    {
        get => ShadowArtifact?.ParentArtifacts ?? parentArtifacts;
        set => parentArtifacts = value;
    }

    public KeyValuePair<string, string>[] FixedVersions { get; set; } = new KeyValuePair<string, string>[0];

    public string[] Tags { get; set; }
    public string[] MissingDependencies { get; set; }

    public ArtifactModel ShadowArtifact { get; set; }

    public bool Equals(ArtifactModel other)
    {
        if (other == null) return false;

        return Group.Id == other.Group.Id && 
            Nuget.ArtifactId == other.Nuget.ArtifactId && 
            Version.SemanticVersion == other.Version.SemanticVersion;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as ArtifactModel);
    }

    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }

    public override string ToString() => $"{GradleImplementation}.{ShadowArtifact?.Packaging ?? Packaging}";
}


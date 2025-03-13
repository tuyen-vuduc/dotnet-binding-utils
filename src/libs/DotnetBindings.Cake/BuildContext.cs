namespace DotnetBindings.Cake;

public class BuildContext : FrostingContext
{
    public string BasePath { get; set; }
    public string Artifact { get; set; }
    public BindingConfig Configs { get; set; }
    public List<ArtifactModel> Artifacts { get; set; }
    public string SlnPath => PathIO.Combine(BasePath, "bindings.g.sln").Replace("\\", "/");

    public BuildContext(ICakeContext context)
        : base(context)
    {
        var defaultBasePath = System.IO.Path.Combine(
            Environment.WorkingDirectory.FullPath,
            "../../../.."
        );

        BasePath = context.Arguments.GetArgument("base-path")
                    ?? defaultBasePath;
        Artifact = context.Arguments.GetArgument("artifact");
    }
}

public class BuildContext : FrostingContext
{
    public string BasePath { get; set; }
    public string GeneratedSlnPath { get; set; }

    public List<ArtifactModel> Artifacts { get; set; }

    public BuildContext(ICakeContext context)
        : base(context)
    {
        var defaultBasePath = System.IO.Path.Combine(
            Environment.WorkingDirectory.FullPath,
            "../../../.."
        );

        BasePath = context.Arguments.GetArgument("base-path")
                    ?? defaultBasePath;
    }
}

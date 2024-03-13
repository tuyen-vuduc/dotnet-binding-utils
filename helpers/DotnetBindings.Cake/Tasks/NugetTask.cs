namespace DotnetBindings.Cake;

[IsDependentOn(typeof(BinderateTask))]
public sealed class NugetTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        var nugetsFolderPath = PathIO.Combine(
            context.BasePath,
            "nugets"
        );
        var settings = new DotNetPackSettings
        {
            Configuration = "Release",
            OutputDirectory = nugetsFolderPath,
        };

        context.DotNetPack(
            context.GeneratedSlnPath,
            settings
        );
    }
}

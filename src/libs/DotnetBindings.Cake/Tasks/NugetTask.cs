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
        var slnPath = PathIO.Combine(
            context.BasePath,
            "bindings.g.sln");

        context.DotNetPack(
            slnPath,
            settings
        );
    }
}

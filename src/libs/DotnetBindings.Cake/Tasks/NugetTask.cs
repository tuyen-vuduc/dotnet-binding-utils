using Cake.Common.Tools.DotNet.Workload.Restore;

namespace DotnetBindings.Cake;

[IsDependentOn(typeof(BinderateTask))]
public sealed class NugetTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.DotNetWorkloadRestore(context.SlnPath);

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
            context.SlnPath,
            settings
        );
    }
}

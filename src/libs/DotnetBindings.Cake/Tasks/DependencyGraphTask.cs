
namespace DotnetBindings.Cake.Tasks;

[IsDependentOn(typeof(InitializeTask))]
public sealed class DependencyGraphTask : AsyncFrostingTask<BuildContext>
{
    public override async Task RunAsync(BuildContext context)
    {
        await base.RunAsync(context);

    }
}

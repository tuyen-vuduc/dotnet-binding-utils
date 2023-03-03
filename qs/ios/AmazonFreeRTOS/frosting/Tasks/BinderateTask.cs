[TaskName("binderate")]
public sealed class BinderateTask : AsyncFrostingTask<BuildContext>
{
    public override async Task RunAsync(BuildContext context)
	{
		context.Projects = await Engine.BinderateAsync(context.ConfigPath, context.BasePath);
    }
}
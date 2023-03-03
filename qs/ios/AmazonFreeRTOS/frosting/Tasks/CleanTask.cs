using Path = System.IO.Path;

[TaskName ("clean")]
public sealed class CleanTask : FrostingTask<BuildContext>
{
	public override void Run(BuildContext context)
	{
		var deleteDirectorySettings = new DeleteDirectorySettings
		{
			Recursive = true,
			Force = true
		};

		context.EnsureDirectoryDoesNotExist(
			Path.Combine(context.BasePath, "external")
		);
		context.EnsureDirectoryDoesNotExist(
			Path.Combine(context.BasePath, "output")
		);
		context.EnsureDirectoryDoesNotExist(
			Path.Combine(context.BasePath, "generated")
		);
	}
}

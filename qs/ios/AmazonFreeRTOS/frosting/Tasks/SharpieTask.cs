[TaskName("sharpie")]
[IsDependentOn(typeof(BinderateTask))]
public class SharpieTask : FrostingTask<BuildContext>
{
	const string sharpieScript = @"bind --output=source/{0} --namespace={0} --sdk=iphoneos16.0 -scope frameworks/{0}.xcframework/ios-arm64/{0}.framework/Headers frameworks/{0}.xcframework/ios-arm64/{0}.framework/Headers/*.h";

	public override void Run (BuildContext context)
	{
		foreach (var projectModel in context.Projects)
		{
			var script = string.Format(sharpieScript,
				projectModel.Name,
				context.BasePath);

			Console.WriteLine("sharpie " + script);

			//ProcessAliases.StartProcess(context, "sharpie", new ProcessSettings
			//{
			//	Arguments = script,
			//	WorkingDirectory = context.BasePath,
			//});
		}
	}
}


using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.MSBuild;
using Cake.Common.Tools.DotNet.Pack;
using Cake.Common.Tools.MSBuild;
using Cake.Common.Tools.NuGet;
using Cake.Common.Tools.NuGet.Pack;
using PathIO = System.IO.Path;
[TaskName("nuget")]
[IsDependentOn(typeof(BinderateTask))]
public class NugetTask : FrostingTask<BuildContext>
{
	public override void Run(BuildContext context)
	{
		context.StartProcess("dotnet", new ProcessSettings
		{
			Arguments = "nuget locals -c all",
		});

		var path = PathIO.Combine(context.BasePath, "generated", "amazon-freertos-ios.sln");
		var outputDir = PathIO.Combine(context.BasePath, "nugets");

		//var settings = new MSBuildSettings()
		//	.SetConfiguration("Release")
		//	//.SetMaxCpuCount(MAX_CPU_COUNT)
		//	.EnableBinaryLogger("./output/nuget.binlog");
		//settings.Targets.Clear();
		//settings.Targets.Add("Restore");
		//settings.Targets.Add("Rebuild");
		//settings.Targets.Add("Pack");
		//settings.Properties.Add("PackageOutputPath", new[] { outputDir });
		//settings.Properties.Add("PackageRequireLicenseAcceptance", new[] { "true" });
		//settings.Properties.Add("DesignTimeBuild", new[] { "false" });

		//context.MSBuild(path, settings);

		var settings = new DotNetPackSettings
		{
			Configuration = "Release",
			OutputDirectory  = outputDir,
		};

		context.DotNetPack(path, settings);
	}
}


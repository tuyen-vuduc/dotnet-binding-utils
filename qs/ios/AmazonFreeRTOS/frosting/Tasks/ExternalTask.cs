using Cake.Core.IO;
using Path = System.IO.Path;

[TaskName("external")]
[IsDependentOn(typeof(BinderateTask))]
public sealed class ExternalTask : FrostingTask<BuildContext>
{
	const string packageSwiftTemplate = @"
// swift-tools-version: 5.6
// The swift-tools-version declares the minimum version of Swift required to build this package.

import PackageDescription

let package = Package(
    name: ""spmx"",
    dependencies: [
        // Dependencies declare other packages that this package depends on.
        {0}
    ]
)
";

	public override void Run(BuildContext context)
	{
		var externalPath = Path.Combine(context.BasePath, "externals");

		var swiftPackageFilePath = Path.Combine(externalPath, "Package.swift");
		context.EnsureDirectoryExists(externalPath);

		CreatePackageSwiftFile(context, swiftPackageFilePath);

		// Leverage Swift Package Manager to download GIT dependency
		ProcessAliases.StartProcess(context, "swift", new ProcessSettings {
			Arguments = "package resolve",
			WorkingDirectory = externalPath,
		});

		var scriptPath = CopyBuildScript(externalPath);

		foreach (var project in context.Projects)
		{
			
		}
	}

	private string CopyBuildScript (string externalPath)
	{
		var buildScriptPath = Path.Combine(externalPath, "build.sh");
		using var buildScriptContent = GetType().Assembly.GetManifestResourceStream("Build.build.sh");
		using var writer = File.OpenWrite(buildScriptPath);
		buildScriptContent.CopyTo(writer);
		return buildScriptPath;
	}

	private void CreatePackageSwiftFile (BuildContext context, string outputPath)
	{
		//var packages = new List<string>();

		//foreach (var project in context.Projects)
		//{
		//	var packageSource = project.Spec.Source;

		//	if (packageSource.Git == null)
		//	{
		//		continue;
		//	}

		//	packages.Add(@$".package(url: ""{packageSource.Git}"", exact: ""{project.Spec.Version}"")");
		//}

		//var packageSwiftFileContent = string.Format(packageSwiftTemplate, string.Join(",\n        ", packages));

		//File.WriteAllText(outputPath, packageSwiftFileContent);
	}
}

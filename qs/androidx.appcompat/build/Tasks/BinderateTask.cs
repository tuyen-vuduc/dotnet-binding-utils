[TaskName("binderate")]
[IsDependentOn(typeof(InitializeTask))]
public sealed class BinderateTask : AsyncFrostingTask<BuildContext>
{
    // Tasks can be asynchronous
    public override async Task RunAsync(BuildContext context)
    {
        string configFile = System.IO.Path.Combine(
            context.BasePath,
            "config.json"
        );

        foreach (var artifact in context.Artifacts)
        {
            Unzip(context, artifact);
        }

        var config = await Engine.BinderateAsync(
            configFile,
            context.BasePath,
            context.Artifacts
        );

        context.GeneratedSlnPath = System.IO.Path.Combine(
            context.BasePath,
            config.SolutionFile
        );
    }

    static void Unzip(BuildContext context, ArtifactModel artifact)
    {
        if (!artifact.IsAAR) return;

        var homeFolder = Platform.IsWindows
                   ? Environment.SpecialFolder.LocalApplicationData
                   : Environment.SpecialFolder.Personal;
        var homeFolderPath = Environment.GetFolderPath(homeFolder);
        var artifactAarPath = System.IO.Path.Combine(
            homeFolderPath,
            artifact.LibRelativePath
        );
        var unzipFolderPath = System.IO.Path.Combine(
            homeFolderPath,
            artifact.LibFolderPath,
            "_aar"
        );

        var unzippedClassesJarPath = System.IO.Path.Combine(
            unzipFolderPath,
            "classes.jar"
        );
        if (File.Exists(unzippedClassesJarPath)) return;

        context.Unzip(
            artifactAarPath,
            unzipFolderPath
        );
    }
}
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DotnetBindings.Cake;

[IsDependentOn(typeof(InitializeTask))]
public sealed class BinderateTask : AsyncFrostingTask<BuildContext>
{
    // Tasks can be asynchronous
    public override async Task RunAsync(BuildContext context)
    {
        foreach (var artifact in context.Artifacts)
        {
            Unzip(context, artifact);
        }

        await Engine.BinderateAsync(
            context.Configs
        ).ContinueWith(t =>
        {
            if (t.IsFaulted)
            {
                context.Log.Error(t.Exception);

                throw t.Exception;  
            }
        });
    }

    static void Unzip(BuildContext context, ArtifactModel artifact)
    {
        if (!artifact.IsAAR) return;

        var homeFolder = Platform.IsWindows
                   ? Environment.SpecialFolder.UserProfile
                   : Environment.SpecialFolder.Personal;
        var homeFolderPath = Environment.GetFolderPath(homeFolder);
        var artifactAarPath = PathIO.Combine(
            homeFolderPath,
            artifact.LibRelativePath
        );
        var unzipFolderPath = PathIO.Combine(
            homeFolderPath,
            artifact.LibFolderPath,
            "_aar"
        );

        if (!Directory.Exists(unzipFolderPath))
        {
            Directory.CreateDirectory(unzipFolderPath);
        }

        var unzippedClassesJarPath = PathIO.Combine(
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
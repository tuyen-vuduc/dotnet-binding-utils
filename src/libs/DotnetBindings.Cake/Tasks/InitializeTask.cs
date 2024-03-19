namespace DotnetBindings.Cake;

public sealed class InitializeTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        var configs = new BindingConfig
        {
            BasePath = context.BasePath,
            SlnPath = context.SlnPath,
        };
        context.Configs = configs;

        var artifacts = configs.Artifacts = Scan(
            context
        );

#if DEBUG
        var configPath = PathIO.Combine(context.BasePath, "artifacts.g.json");
        if (File.Exists(configPath))
        {
            File.Delete(configPath);
        }

        var json = artifacts.Serialize();
        File.WriteAllText(configPath, json);
#endif

        UnzipAar(context, artifacts);

        context.Artifacts = artifacts;
    }

    private void UnzipAar(BuildContext context, List<ArtifactModel> artifacts)
    {
        const string bindingDefaultFile = "binding-default.zip";
        if (!File.Exists(bindingDefaultFile))
        {
            using (var stream = GetType()
                                .Assembly
                                .GetManifestResourceStream(
                                    $"DotnetBindings.Cake.{bindingDefaultFile}"
                                ))
            {
                using (var writer = File.OpenWrite(bindingDefaultFile))
                {
                    stream!.CopyTo(writer);
                }
            }
        }

        var artifactsToBind = artifacts
            .Where(x => !x.Nuget.DependencyOnly)
            .ToList();

        foreach (var artifact in artifactsToBind)
        {
            var artifactFolderPath = PathIO.Combine(
                context.BasePath,
                artifact.RelativeBindingFolderPath
            );

            if (Directory.Exists(artifactFolderPath)) continue;

            var bindingDefaultZipFilePath = PathIO.Combine(
                ".",
                bindingDefaultFile
            );
            context.Unzip(
                bindingDefaultZipFilePath,
                artifactFolderPath
            );
        }
    }

    private List<ArtifactModel> Scan(BuildContext context)
    {
        var allArtifacts = new List<ArtifactModel>();
        var scannedItems = ArtifactScanner.Scan(
            allArtifacts,
            context.BasePath,
            context.Artifact,
            log =>
            {
                if (log.Contains("MISSING"))
                    context.Log.Information(log);
                else if (log.Contains("EXISTS"))
                    context.Log.Information(log);
            }
        );
        allArtifacts.AddRange(scannedItems);

        return allArtifacts
                .DistinctBy(x => x.GroupAndArtifactId())
                .ToList();
    }
}

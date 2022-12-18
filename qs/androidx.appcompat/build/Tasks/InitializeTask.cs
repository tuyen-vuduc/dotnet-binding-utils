[TaskName("init")]
public sealed class InitializeTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        var configs = ReadConfigs(context);

        if (configs.Artifacts?.Count <= 0)
        {
            context.Log.Error("No artifacts supplied");

            return;
        }

        var artifacts = Scan(new List<ArtifactModel>(configs.Artifacts), context);

        if (configs.Debug.DumpModels)
        {
            var configPath = PathIO.Combine(context.BasePath, "artifacts.g.json");
            if (File.Exists(configPath))
            {
                File.Delete(configPath);
            }

            var json = artifacts.Serialize();
            File.WriteAllText(configPath, json);
        }

        var sourceFolderPath = System.IO.Path.Combine(
            context.BasePath,
            "source"
            );

        var artifactsToBind = artifacts
            .Where(x => !x.DependencyOnly)
            .ToList();

        foreach (var artifact in artifactsToBind)
        {
            var artifactFolderPath = System.IO.Path.Combine(
                sourceFolderPath,
                artifact.GroupId,
                artifact.ArtifactId
            );

            if (Directory.Exists(artifactFolderPath)) continue;

            var bindingDefaultZipFilePath = System.IO.Path.Combine(
                context.BasePath,
                "binding-default.zip"
            );
            context.Unzip(
                bindingDefaultZipFilePath,
                artifactFolderPath
            );
        }

        context.Artifacts = artifacts;
    }

    private List<ArtifactModel> Scan(List<ArtifactModel> artifacts, BuildContext context)
    {
        var metadataBasePath = PathIO.Combine(
            context.BasePath,
            "../.."
        );

        var allArtifacts = new List<ArtifactModel>();

        foreach (var artifact in artifacts)
        {
            var scannedItems = ArtifactScanner.Scan(
                artifacts,
                metadataBasePath,
                artifact.GroupId,
                artifact.ArtifactId,
                artifact.Version,
                log => {
                    if (log.Contains("MISSING"))
                        context.Log.Information(log);
                    else if (log.Contains("EXISTS"))
                        context.Log.Information(log);
                }
            );
            allArtifacts.AddRange(scannedItems);

            // TODO Handle multi artifacts at once
            //allArtifacts = allArtifacts
            //    .DistinctBy(x => x.GroupAndArtifactId())
            //    .ToList();

            break;
        }

        return allArtifacts;
    }

    private BindingConfig ReadConfigs(BuildContext context)
    {
        var configFilePath = PathIO.Combine(
            context.BasePath,
            "config.json"
        );

        using var stream = File.OpenRead(configFilePath);

        return stream.Deserialize<BindingConfig>();
    }
}

using System;

namespace DotnetBindings.Cake;

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

        configs.BasePath = context.BasePath;
        context.Configs = configs;

        context.GeneratedSlnPath = System.IO.Path.Combine(
            context.BasePath,
            configs.SolutionFile
        );

        var artifacts = configs.Artifacts = Scan(
            new List<ArtifactModel>(configs.Artifacts),
            context
        );

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

        UnzipAar(context, artifacts);

        context.Artifacts = artifacts;
    }

    private void UnzipAar(BuildContext context, List<ArtifactModel> artifacts)
    {
        const string bindingDefaultFile = "binding-default.zip";
        if (!File.Exists(bindingDefaultFile)) {
            using(var stream = GetType()
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
                ".",
                bindingDefaultFile
            );
            context.Unzip(
                bindingDefaultZipFilePath,
                artifactFolderPath
            );
        }
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
                },
                artifact.GroupName,
                artifact.ArtifactName,
                artifact.Tags,
                artifact.NugetRevision ?? context.Configs.NugetRevision
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

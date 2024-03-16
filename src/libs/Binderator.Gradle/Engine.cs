using System.Threading.Tasks;
using RazorLight;

namespace Binderator.Gradle;

public class Engine
{
    public static Task<BindingConfig> BinderateAsync(string artifact, string basePath)
    {
        var selectedArtifact = Util.FromArtifactString(basePath, artifact, true);

        BindingConfig config = new BindingConfig
        {
            BasePath = basePath,
            Artifacts = new List<ArtifactModel>
            {
                selectedArtifact,
            },
            SlnPath = Path.Combine(basePath, "bindings.g.sln"),
        };

        return BinderateAsync(config)
            .ContinueWith(t =>
            {
                return config;
            });
    }

    public static Task BinderateAsync(BindingConfig config)
    {
        return ProcessConfig(config);
    }

    static async Task ProcessConfig(BindingConfig config)
    {
        var slnProjModels = new Dictionary<string, BindingProjectModel>();
        var models = BuildProjectModels(config);

#if DEBUG
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(models);
        File.WriteAllText(Path.Combine(config.BasePath, "projects.g.json"), json);
#endif

        var engine = new RazorLightEngineBuilder()
            .UseMemoryCachingProvider()
            .Build();
        var templates = new Dictionary<string, string>()
        {
            { "README.cshtml", "README.md" },
            { "LICENSE.cshtml", "LICENSE" },
            { "Targets.cshtml", "{0}.targets" },
            { "Project.cshtml", "{0}.csproj" },
        };

        foreach (var model in models)
        {
            foreach (var template in templates)
            {
                var inputTemplateFile = Path.Combine(config.BasePath, "src", template.Key);
                var templateSrc = File.ReadAllText(inputTemplateFile);

                var outputRelativePath = Path.Combine(
                    model.Artifact.RelativeBindingFolderPath,
                    string.Format(template.Value, model.Artifact.Nuget.PackageId));
                var outputFilePath = Path.Combine(
                    config.BasePath,
                    outputRelativePath
                    );

                string result = await engine.CompileRenderStringAsync(inputTemplateFile, templateSrc, model);

                File.WriteAllText(outputFilePath, result);

                // We want to collect all the models for the .csproj's so we can add them to a .sln file after
                if (!slnProjModels.ContainsKey(outputRelativePath) && outputRelativePath.EndsWith(".csproj"))
                    slnProjModels.Add(outputRelativePath, model);
            }
        }

        var sln = SolutionFileBuilder.Build(config, slnProjModels);
        File.WriteAllText(config.SlnPath, sln);
    }

    static List<BindingProjectModel> BuildProjectModels(BindingConfig config)
    {
        var projectModels = new List<BindingProjectModel>();
        var exceptions = new List<Exception>();

        foreach (var artifact in config.Artifacts)
        {
            if (artifact.DependencyOnly)
                continue;

            var projectModel = new BindingProjectModel
            {
                Config = config,
                Artifact = artifact,
            };
            projectModels.Add(projectModel);

            // Gather maven dependencies to try and map out nuget dependencies
            foreach (var mavenDep in artifact.ParentArtifacts)
            {
                if (!ShouldIncludeDependency(config, artifact, mavenDep, exceptions))
                    continue;

                var parentArtifact = config.Artifacts
                                        .FirstOrDefault(x => x.Nuget.PackageId == mavenDep.Key);

                projectModel.NuGetDependencies.Add(parentArtifact);
            }

        }

        if (exceptions.Any())
            throw new AggregateException(exceptions.ToArray());


        return projectModels;
    }

    static bool ShouldIncludeDependency(BindingConfig config, ArtifactModel artifact, KeyValuePair<string, string> dependency, List<Exception> exceptions)
    {
        // We always care about 'compile' scoped dependencies
        if (string.Equals(dependency.Value, "compile", StringComparison.OrdinalIgnoreCase))
            return true;

        if (string.Equals(dependency.Value, "runtime", StringComparison.OrdinalIgnoreCase))
            return true;

        // TODO need to check other cases: runtime, etc.

        return false;
    }
}

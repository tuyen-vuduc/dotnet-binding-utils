using System.Threading.Tasks;
using RazorLight;

namespace Binderator.Gradle;

public class Engine
{
    public static Task<BindingConfig> BinderateAsync(string configFile, string basePath, List<ArtifactModel> artifacts)
    {
        var config = JsonSerializer.Deserialize<BindingConfig>(
            File.ReadAllText(configFile),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                Converters =
                {
                    new NuGetVersionJsonValueConverter(),
                }
            }
        );

        if (!string.IsNullOrEmpty(basePath))
            config.BasePath = basePath;

        config.Artifacts = artifacts;

        return BinderateAsync(config)
            .ContinueWith(t => config);
    }

    public static async Task BinderateAsync(BindingConfig config)
    {
        await ProcessConfig(config);
    }

    static async Task ProcessConfig(BindingConfig config)
    {
        var slnProjModels = new Dictionary<string, BindingProjectModel>();
        var models = BuildProjectModels(config);

        if (config.Debug.DumpModels) {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(models);

            File.WriteAllText(Path.Combine(config.BasePath, "projects.g.json"), json);
        }

        var engine = new RazorLightEngineBuilder()
            .UseMemoryCachingProvider()
            .Build();

        foreach (var model in models)
        {
            var template_set = config.GetTemplateSet(string.Empty);

            foreach (var template in template_set.Templates)
            {
                var inputTemplateFile = Path.Combine(config.BasePath, template.TemplateFile);
                var templateSrc = File.ReadAllText(inputTemplateFile);

                var outputFile = new FileInfo(template.GetOutputFile(config, model));
                if (!outputFile.Directory.Exists)
                    outputFile.Directory.Create();

                string result = await engine.CompileRenderStringAsync(inputTemplateFile, templateSrc, model);

                File.WriteAllText(outputFile.FullName, result);

                // We want to collect all the models for the .csproj's so we can add them to a .sln file after
                if (!slnProjModels.ContainsKey(outputFile.FullName) && template.OutputFileRule.EndsWith(".csproj"))
                    slnProjModels.Add(outputFile.FullName, model);
            }
        }

        if (!string.IsNullOrEmpty(config.SolutionFile))
        {
            var slnPath = Path.Combine(config.BasePath, config.SolutionFile.Replace('/', Path.DirectorySeparatorChar));
            var sln = SolutionFileBuilder.Build(config, slnProjModels);
            File.WriteAllText(slnPath, sln);
        }
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

            // TODO Needs to check on another project
            //var artifactLibNameWithVersion = $"{mavenArtifact.ArtifactId}-{mavenArtifact.Version}.{mavenArtifact.Packaging ?? "jar"}";
            //var artifactLibRelativePath = mavenArtifact.Files.First(x => x.EndsWith(artifactLibNameWithVersion));
            //var artifactLibDir = artifactLibRelativePath.Replace(artifactLibNameWithVersion, string.Empty).Trim('/');
            //var artifactExtractDir = Path.Combine(artifactLibDir, $"{mavenArtifact.ArtifactId}-{mavenArtifact.Version}");
            //var proguardFile = Path.Combine(artifactExtractDir, "proguard.txt");

            // Gather maven dependencies to try and map out nuget dependencies
            foreach (var mavenDep in artifact.ParentArtifacts)
            {
                if (!ShouldIncludeDependency(config, artifact, mavenDep, exceptions))
                    continue;

                var parentArtifact = config.Artifacts
                                        .FirstOrDefault(x => x.NugetPackageId == mavenDep.Key);

                var fixedParentVersion = config.FixedDependencies?
                                    .FirstOrDefault(x => x.Key == mavenDep.Key)
                                    .Value;
                if (fixedParentVersion != null && fixedParentVersion > parentArtifact.NugetVersion)
                {
                    parentArtifact.NugetVersion = fixedParentVersion;
                }

                projectModel.NuGetDependencies.Add(parentArtifact);
            }

        }

        if (exceptions.Any())
            throw new AggregateException(exceptions.ToArray());


        return projectModels;
    }

    static bool ShouldIncludeDependency(BindingConfig config, ArtifactModel artifact, KeyValuePair<string, string> dependency, List<Exception> exceptions)
    {
        if (string.IsNullOrWhiteSpace(dependency.Value)) return true;

        // We always care about 'compile' scoped dependencies
        if (string.Equals(dependency.Value, "compile", StringComparison.OrdinalIgnoreCase))
            return true;

        if (string.Equals(dependency.Value, "runtime", StringComparison.OrdinalIgnoreCase))
            return true;

        // TODO need to check other cases: runtime, etc.

        return false;
    }

    static string GetRelativePath(string filespec, string folder)
    {
        Uri pathUri = new Uri(filespec);
        // Folders must end in a slash
        if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.OrdinalIgnoreCase))
            folder += Path.DirectorySeparatorChar;
        Uri folderUri = new Uri(folder);
        return Uri.UnescapeDataString(folderUri.MakeRelativeUri(pathUri).ToString().Replace('/', Path.DirectorySeparatorChar));
    }

    static Dictionary<string, string> MergeValues(Dictionary<string, string> dest, Dictionary<string, string> src)
    {
        dest = dest ?? new Dictionary<string, string>();
        if (src != null)
        {
            foreach (var kvp in src)
            {
                dest[kvp.Key] = kvp.Value;
            }
        }
        return dest;
    }
}

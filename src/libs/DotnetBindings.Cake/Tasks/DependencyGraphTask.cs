

using System.Linq;
using System.Text;

namespace DotnetBindings.Cake.Tasks;

[TaskName("deps")]
[IsDependentOn(typeof(InitializeTask))]
public sealed class DependencyGraphTask : AsyncFrostingTask<BuildContext>
{
    public override async Task RunAsync(BuildContext context)
    {
        var configs = context.Configs;
        if (configs == null)
        {
            throw new InvalidOperationException("Configs must be initialized before running this task.");
        }

        var artifacts = configs.Artifacts;
        if (artifacts == null || !artifacts.Any())
        {
            throw new InvalidOperationException("Artifacts must be initialized before running this task.");
        }

        var scannedItems = new Dictionary<string, DependencyNode>();
        var artifact = artifacts.Single(x => x.GradleImplementation == context.Artifact);

        var item = CreateDependencyNode(artifact, artifacts, scannedItems);

        var outputFilePath = PathIO.Combine(
            configs.BasePath,
            "dependency-graph.g.txt"
        );

        var stringBuilder = new StringBuilder();
        AppendDepenencies(
            stringBuilder,
            item!
        );

        await File.WriteAllTextAsync(
            outputFilePath,
            stringBuilder.ToString()
        );
    }

    void AppendDepenencies(
        StringBuilder stringBuilder,
        DependencyNode node,
        int level = 0
    )
    {
        var indentation = new string(' ', level*2);
        stringBuilder
            .AppendLine(
                $"{indentation}- {node.Key}"
            );

        foreach (var dep in node.Dependencies)
        {
            AppendDepenencies(
                stringBuilder,
                dep,
                level + 1
            );
        }
    }

    private DependencyNode? CreateDependencyNode(ArtifactModel artifact, List<ArtifactModel> artifacts, Dictionary<string, DependencyNode> scannedItem)
    {
        if (artifact.Nuget.DependencyOnly) return default;

        var deps = new List<DependencyNode>();

        foreach (var item in artifact.ParentArtifacts)
        {
            var parentArtifact = artifacts
                .SingleOrDefault(x => x.Nuget.PackageId == item.Key);

            if (parentArtifact is null) continue;

            if (scannedItem.ContainsKey(parentArtifact.Key))
            {
                deps.Add(scannedItem[parentArtifact.Key]);
                continue;
            }

            var parentNode = CreateDependencyNode(parentArtifact, artifacts, scannedItem);

            if (parentNode is null) continue;

            deps.Add(parentNode);
        }

        var node = new DependencyNode
        {
            Key = artifact.GradleImplementation,
            Dependencies = deps,
        };
        scannedItem.Add(artifact.Key, node);
        return node;
    }

    record DependencyNode
    {
        public required string Key { get; init; }
        public IEnumerable<DependencyNode> Dependencies { get; init; } = Enumerable.Empty<DependencyNode>();
    }
}

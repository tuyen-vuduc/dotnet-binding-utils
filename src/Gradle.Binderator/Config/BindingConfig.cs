using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Gradle.Binderator;

public class BindingConfig
{
	[JsonProperty("basePath")]
	public string BasePath { get; set; } = null;
	
    [JsonProperty("generatedDir")]
    public string GeneratedDir { get; set; }

	[JsonProperty("templates")]
	public List<TemplateConfig> Templates { get; set; } = new List<TemplateConfig>();

	[JsonProperty("NugetVersionSuffix")]
	public string NugetVersionSuffix { get; set; } = null;

	[JsonProperty("slnFile")]
	public string SolutionFile { get; set; } = null;

	public List<ArtifactModel> MavenArtifacts { get; set; } = new List<ArtifactModel>();

	[JsonProperty("debug")]
	public BindingConfigDebug Debug { get; set; } = new BindingConfigDebug();

	[JsonProperty("additionalProjects")]
	public List<string> AdditionalProjects { get; set; } = new List<string>();

	/// True to consider 'Runtime' dependencies from a POM file, False to ignore them.
	[JsonProperty("strictRuntimeDependencies")]
	public bool StrictRuntimeDependencies { get; set; }

	[JsonProperty("excludedRuntimeDependencies")]
	public string ExcludedRuntimeDependencies { get; set; }

	[JsonProperty("metadata")]
	public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();

	[JsonProperty("templateSets")]
	public List<TemplateSetModel> TemplateSets { get; set; } = new List<TemplateSetModel>();

	public TemplateSetModel GetTemplateSet(string name)
	{
		// If an artifact doesn't specify a template set, first try using the original
		// single template list if it exists.  If not, look for a template set called "default".
		if (string.IsNullOrEmpty(name)) {
			if (Templates.Any())
				return new TemplateSetModel { Templates = Templates };

			name = "default";
		}

		var set = TemplateSets.FirstOrDefault(s => s.Name == name);

		if (set == null)
			throw new ArgumentException($"Could not find requested template set '{name}'");

		return set;
	}
}

public class BindingConfigDebug
{
	public bool DebugMode { get; set; } = false;
	public bool DumpModels { get; set; } = false;
}

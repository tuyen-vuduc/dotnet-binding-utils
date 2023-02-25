using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Binderator.Gradle;

public class BindingConfig
{
	public string BasePath { get; set; } = null;
	
    public string GeneratedDir { get; set; }

	public List<TemplateConfig> Templates { get; set; } = new List<TemplateConfig>();

	public string NugetVersionSuffix { get; set; } = null;

	public string SolutionFile { get; set; } = null;

	public BindingConfigDebug Debug { get; set; } = new BindingConfigDebug();

	public List<string> AdditionalProjects { get; set; } = new List<string>();

	/// True to consider 'Runtime' dependencies from a POM file, False to ignore them.
	public bool StrictRuntimeDependencies { get; set; }

	public string ExcludedRuntimeDependencies { get; set; }

	public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();

	public List<TemplateSetModel> TemplateSets { get; set; } = new List<TemplateSetModel>();

	public List<ArtifactModel> Artifacts { get; set; }

	public Dictionary<string, NuGetVersion> FixedDepedencies { get; set; }

	public string[] TargetFrameworks { get; set; }
	public string[] Tags { get; set; }

	public string ProjectUrl { get; set; }
	public string IconPath { get; set; }
	public string LicensePath { get; set; }
    public string GroupName { get; set; }
    public int NugetRevision { get; set; }

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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Binderator.Gradle;

public class TemplateConfig
{
	public TemplateConfig()
	{
	}

	public TemplateConfig(string templateFile, string outputFileRule)
	{
		TemplateFile = templateFile ?? throw new ArgumentNullException(nameof(templateFile));
		OutputFileRule = outputFileRule ?? throw new ArgumentNullException(nameof(outputFileRule));
	}

	[JsonProperty("templateFile")]
	public string TemplateFile { get; set; }

	[JsonProperty("outputFileRule")]
	public string OutputFileRule { get; set; }

	[JsonProperty("metadata")]
	public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();

	public string GetOutputFile(BindingConfig config, BindingProjectModel model)
	{
		var p = OutputFileRule
				 .Replace("{generated}", config.GeneratedDir)
				 .Replace("{groupid}", model.Artifact.GroupId)
				 .Replace("{artifactid}", model.Artifact.ArtifactId)
				 .Replace("{nugetid}", model.Artifact.NugetPackageId);

		return System.IO.Path.Combine(config.BasePath, p);
	}
}

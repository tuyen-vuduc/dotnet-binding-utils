using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Gradle.Binderator;

public class TemplateSetModel
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("templates")]
	public List<TemplateConfig> Templates { get; set; } = new List<TemplateConfig> ();
}

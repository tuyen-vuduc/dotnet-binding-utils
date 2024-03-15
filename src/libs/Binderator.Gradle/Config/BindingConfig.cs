namespace Binderator.Gradle;

public class BindingConfig
{
	public string BasePath { get; set; } = null;
	
	public List<ArtifactModel> Artifacts { get; set; }
    public string SlnPath { get; set; }
}

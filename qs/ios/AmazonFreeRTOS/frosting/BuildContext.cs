using Path = System.IO.Path;

public class BuildContext : FrostingContext
{
    public bool IsLocalBuild { get; set; }
    public List<BindingProjectModel> Projects { get; set; }

    public string ConfigPath => Path.Combine(BasePath ?? string.Empty, "config.json");
	public string BasePath { get; set; }

	public BuildContext(ICakeContext context)
        : base(context)
    {
        IsLocalBuild = string.IsNullOrWhiteSpace (Environment.GetEnvironmentVariable("AGENT_ID"));

		Log.Information($"Is a local build? {IsLocalBuild}");

    	BasePath = context.Arguments.GetArgument("base-path") ?? "../";
		Log.Information($"BASE_PATH: {BasePath}");
	}
}

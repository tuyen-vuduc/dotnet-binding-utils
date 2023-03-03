using CocoaPods;

public static class CakeContextExtensions
{
	public static bool DirectoryExists(this ICakeContext context, string path)
	{
		return DirectoryAliases.DirectoryExists(context, path);
	}

	public static void DeleteDirectory(this ICakeContext context, string path, DeleteDirectorySettings settings)
	{
		DirectoryAliases.DeleteDirectory(context, path, settings);
	}

	public static void EnsureDirectoryExists(this ICakeContext context, string path)
	{
		DirectoryAliases.EnsureDirectoryExists(context, path);
	}

	public static void EnsureDirectoryDoesNotExist(this ICakeContext context, string path)
	{
		DirectoryAliases.EnsureDirectoryDoesNotExist(context, path);
	}


	public static string[] BuildPodLines(this PodSpecDto spec)
	{
		var podLines = new List<string>();
		var podLine = spec.BuildBasePodLine();

		if (spec.Subspecs?.Count <= 0)
		{
			podLines.Add(string.Format(podLine, spec.Name));
			return podLines.ToArray();
		}

		foreach (var subSpec in spec.Subspecs)
			podLines.Add(string.Format(podLine, $"{subSpec.Name}"));

		return podLines.ToArray();
	}

	static string BuildBasePodLine(this PodSpecDto spec)
	{
		return $"\tpod '{{0}}', '{spec.Version}'";

		// switch (Source) {
		// case PodSource.PodVersion:
		// 	return $"\tpod '{{0}}', '{spec.Version}'";
		// case PodSource.LocalPath:
		// 	return $"\tpod '{{0}}', :path => '{LocalPath.FullPath}'";
		// case PodSource.Repository:
		// 	var pod = $"\tpod '{{0}}', :git => '{Repository.Url}'";

		// 	if (!string.IsNullOrWhiteSpace (Repository.Branch))
		// 		pod += $", :branch => '{Repository.Branch}'";
		// 	else if (!string.IsNullOrWhiteSpace (Repository.Tag))
		// 		pod += $", :tag => '{Repository.Tag}'";
		// 	else if (!string.IsNullOrWhiteSpace (Repository.Commit))
		// 		pod += $", :commit => '{Repository.Commit}'";

		// 	return pod;
		// }
		// return null;
	}
}

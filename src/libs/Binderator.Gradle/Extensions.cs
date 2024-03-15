using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binderator.Gradle;

public static class Extensions
{
	public static NuGetVersion ToNuGetVersion(this SemanticVersion semanticVersion, int nugetRevision = default)
	{
		var revision = nugetRevision;
		var releaseLabel = semanticVersion.Release;
		if (int.TryParse(semanticVersion.Release, out var intValue))
		{
			// NuGetVersion doesn't allow to use a number as a release label.
			// Here we assume
			//   - this kind of release label is always smaller than 90
			//   - our revsion for NuGet package is always smaller than 100
			// Then when reading the convention, we will understand
			//   - which part is the native release label: (wrapped/100) - 10
			//   - which part is the nuget revision: (wrapped%100)
			// NOTE: We can't simply use semantic release label as the release label of the nuget package.
			// If we do so, Nuget will consider that package is a pre-release version
			revision = (intValue + 10) * 100 + nugetRevision;
			releaseLabel = string.Empty;
		}

		return new NuGetVersion(
			semanticVersion.Major,
			semanticVersion.Minor,
			semanticVersion.Patch,
			revision, releaseLabel,
			semanticVersion.Metadata);
	}

	public static string OrEmpty (this string value) => value ?? string.Empty;

	public static string GroupAndArtifactId (this ArtifactModel dependency) => $"{dependency.GroupId}.{dependency.ArtifactId}";

	//public static bool IsCompileDependency (this ArtifactModel dependency) => string.IsNullOrWhiteSpace (dependency.Scope) || dependency.Scope.ToLowerInvariant ().Equals ("compile");

	//public static bool IsRuntimeDependency (this ArtifactModel dependency) => dependency?.Scope != null && dependency.Scope.ToLowerInvariant ().Equals ("runtime");
}

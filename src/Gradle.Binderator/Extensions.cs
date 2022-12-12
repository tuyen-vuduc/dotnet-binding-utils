using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gradle.Binderator;

public static class Extensions
{
	public static string OrEmpty (this string value) => value ?? string.Empty;

	public static string GroupAndArtifactId (this ArtifactModel dependency) => $"{dependency.GroupId}.{dependency.ArtifactId}";

	//public static bool IsCompileDependency (this ArtifactModel dependency) => string.IsNullOrWhiteSpace (dependency.Scope) || dependency.Scope.ToLowerInvariant ().Equals ("compile");

	//public static bool IsRuntimeDependency (this ArtifactModel dependency) => dependency?.Scope != null && dependency.Scope.ToLowerInvariant ().Equals ("runtime");
}

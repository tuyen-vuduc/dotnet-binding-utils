using System;
using System.Collections.Generic;
using System.Reflection;

namespace Gradle.Binderator;

public class ArtifactModel : IEquatable<ArtifactModel>
{
    public string GroupId { get; set; }

    public string ArtifactId { get; set; }
    public string Version { get; set; }
    public string Packaging { get; set; }
    public string NugetPackageId { get; set; }
    public string NugetVersion { get; set; }
    public bool DependencyOnly { get; set; } = false;

    public string[] Files { get; set; }

    public string Key => $"{GroupId}:{ArtifactId}";
    public string GradleImplenetation => $"{GroupId}:{ArtifactId}:{Version}";

    public bool IsAAR => Packaging == "aar";
    public string ArtifactWithVersion => $"{ArtifactId}-{Version}";

    public string LibRelativePath => IsAAR
        ? Files?.First(x => x.EndsWith(ArtifactWithVersion + ".aar"))
        : Files?.First(x => x.EndsWith(ArtifactWithVersion + ".jar"));

    public string SourcesJarRelativeFilePath => Files?.FirstOrDefault(x => x.EndsWith("-sources.jar"));
    public string JavadocJarRelativeFilePath => Files?.FirstOrDefault(x => x.EndsWith("-javadoc.jar"));

    public string LibFolderPath => LibRelativePath?.Substring(
        0,
        LibRelativePath.IndexOf(ArtifactWithVersion)
    ).Trim('/');

    public string ProguardFileRelativePath => IsAAR ? System.IO.Path.Combine(
        LibFolderPath ?? string.Empty,
        "_aar",
        "proguard.txt"
    ) : string.Empty;

    public (string NugetPackageId, string Scope)[] ParentArtifacts { get; set; }

    public bool Equals(ArtifactModel other)
    {
        if (other == null) return false;

        return GroupId == other.GroupId && ArtifactId == other.ArtifactId && Version == other.Version;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as ArtifactModel);
    }

    public override int GetHashCode()
    {
        return $"{GroupId}:{ArtifactId}-{Version}.{Packaging}".GetHashCode();
    }
}


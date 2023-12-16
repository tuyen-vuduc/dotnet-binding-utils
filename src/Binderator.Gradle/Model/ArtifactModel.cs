﻿using System.Text.Json.Serialization;

namespace Binderator.Gradle;

public class ArtifactModel : IEquatable<ArtifactModel>
{
    public string GroupId { get; set; }

    public string ArtifactId { get; set; }
    public SemanticVersion Version { get; set; }
    public string Packaging { get; set; }
    public string NugetPackageId { get; set; }
    public NuGetVersion NugetVersion { get; set; }
    public bool DependencyOnly { get; set; } = false;
    public int? NugetRevision { get; set; }

    public string ProjectUrl { get; set; }
    public string IconPath { get; set; }
    public string LicensePath { get; set; }

    public string[] Files { get; set; }

    public string Key => $"{GroupId}:{ArtifactId}";
    public string GradleImplementation => $"{GroupId}:{ArtifactId}:{Version}";

    public bool IsAAR => Packaging == "aar" || Files?.Any(x => x.EndsWith(ArtifactWithVersion + ".aar")) == true;
    public string ArtifactWithVersion => $"{ArtifactId}-{Version}";

    public string LibRelativePath => IsAAR
        ? Files?.FirstOrDefault(x => x.EndsWith(ArtifactWithVersion + ".aar")).Replace("\\", "/")
        : Files?.FirstOrDefault(x => x.EndsWith(ArtifactWithVersion + ".jar")).Replace("\\", "/");

    public string SourcesJarRelativeFilePath => Files?.FirstOrDefault(x => x.EndsWith("-sources.jar"));
    public string JavadocJarRelativeFilePath => Files?.FirstOrDefault(x => x.EndsWith("-javadoc.jar"));

    public string LibFolderPath => LibRelativePath?.Substring(
        0,
        LibRelativePath.IndexOf(ArtifactWithVersion)
    ).Trim('/').Replace("\\", "/");

    public string ProguardFileRelativePath => IsAAR ? System.IO.Path.Combine(
        LibFolderPath ?? string.Empty,
        "_aar",
        "proguard.txt"
    ).Replace("\\", "/") : string.Empty;

    public KeyValuePair<string, string>[] ParentArtifacts { get; set; }
    public string GroupName { get; set; }
    public string ArtifactName { get; set; }
    public string[] Tags { get; set; }

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
        return ToString().GetHashCode();
    }

    public override string ToString() => $"{GroupId}:{ArtifactId}-{Version}.{Packaging}";
}


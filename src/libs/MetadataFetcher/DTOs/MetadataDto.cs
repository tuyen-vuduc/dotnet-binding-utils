using System.Text.Json;
using System.Text.Json.Serialization;
using NuGet.Versioning;

class MetadataDto {
    public string[]? Versions { get; set; }
}

class NugetInfoDto {
    public string PackageId { get; set; }
    public string Name { get; set; }
    public string HomePageUrl { get; set; }
    public string GuideUrl { get; set; }
    public string Relocated { get; set; }
    public bool DependencyOnly { get; set; } = true;
    public VersionMappingDto[] VersionMappings { get; set; } = Array.Empty<VersionMappingDto>();
}

class VersionMappingDto
{
    public string Prefix { get; set; }
    public VersionMappingMethod Method { get; set; }
    public NuGetVersion FromVersion { get; set; }
    public NuGetVersion ToVersion { get; set; }
}

enum VersionMappingMethod {
    Prefix,
    CombinedToMinor
}
public record VersionDto
{
    public int Revision { get; set; }
    public NuGetVersion NugetVersion { get; set; }
    public bool? WithoutPatch { get; set; }
}
using System.Text.Json;
using NuGet.Versioning;

class MetadataDto {
    public string[]? Versions { get; set; }
}

class NugetInfoDto {
    public string PackageId { get; set; }
    public string Name { get; set; }
    public string HomePageUrl { get; set; }
    public string GuideUrl { get; set; }
    public VersionMappingDto[] VersionMappings { get; set; } = Array.Empty<VersionMappingDto>();
}

class VersionMappingDto {
    public VersionMappingMethod Method { get; set; }
    public NuGetVersion FromVersion { get; set; }
    public NuGetVersion ToVersion { get; set; }
    public string Prefix { get; set; }
}

enum VersionMappingMethod {
    Prefix,
    CombinedToMinor
}

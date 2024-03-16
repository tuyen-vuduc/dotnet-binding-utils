using System.Text.Json.Serialization;

namespace Binderator.Gradle;

public record GroupModel
{
    [JsonIgnore]
    public string Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Owner { get; set; }
}

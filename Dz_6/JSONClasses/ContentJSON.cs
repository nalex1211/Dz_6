using System.Text.Json.Serialization;

namespace Dz_6.JSONClasses;

internal class ContentJSON
{
    //[JsonIgnore]
    public int PublishingHouseId { get; init; }
    //[JsonPropertyName("Name")]
    public string? Title { get; init; }
    public PublishingHouseJSON? PublishingHouse { get; init; }
}

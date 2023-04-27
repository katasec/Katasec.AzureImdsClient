using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class TagsList
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

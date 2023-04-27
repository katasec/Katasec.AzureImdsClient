using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class Plan
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("product")]
    public string? Product { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}
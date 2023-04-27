using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;


public class ImageReference
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}


using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class ResourceDisk
{
    [JsonPropertyName("size")]
    public string? Size { get; set; }
}
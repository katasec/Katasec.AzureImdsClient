using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class DiffDiskSettings
{
    [JsonPropertyName("option")]
    public string? Option { get; set; }
}
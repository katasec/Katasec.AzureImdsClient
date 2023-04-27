using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class PublicKey
{
    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

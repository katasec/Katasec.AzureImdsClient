using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;


public class EncryptionSettings
{
    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }
}
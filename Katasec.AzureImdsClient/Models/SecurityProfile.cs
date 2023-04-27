using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class SecurityProfile
{
    [JsonPropertyName("secureBootEnabled")]
    public string? SecureBootEnabled { get; set; }

    [JsonPropertyName("virtualTpmEnabled")]
    public string? VirtualTpmEnabled { get; set; }
}

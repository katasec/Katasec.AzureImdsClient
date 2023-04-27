using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class OsProfile
{
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    [JsonPropertyName("disablePasswordAuthentication")]
    public string? DisablePasswordAuthentication { get; set; }
}
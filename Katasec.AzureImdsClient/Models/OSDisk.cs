using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class OsDisk
{
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    [JsonPropertyName("diffDiskSettings")]
    public DiffDiskSettings? DiffDiskSettings { get; set; }

    [JsonPropertyName("diskSizeGB")]
    public string? DiskSizeGb { get; set; }

    [JsonPropertyName("encryptionSettings")]
    public EncryptionSettings? EncryptionSettings { get; set; }

    [JsonPropertyName("image")]
    public Image? Image { get; set; }

    [JsonPropertyName("managedDisk")]
    public ManagedDisk? ManagedDisk { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    [JsonPropertyName("vhd")]
    public Image? Vhd { get; set; }

    [JsonPropertyName("writeAcceleratorEnabled")]
    public string? WriteAcceleratorEnabled { get; set; }
}
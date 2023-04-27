using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;
public class StorageProfile
{
    [JsonPropertyName("dataDisks")]
    public string[]? DataDisks { get; set; }

    [JsonPropertyName("imageReference")]
    public ImageReference? ImageReference { get; set; }

    [JsonPropertyName("osDisk")]
    public OsDisk? OsDisk { get; set; }

    [JsonPropertyName("resourceDisk")]
    public ResourceDisk? ResourceDisk { get; set; }
}
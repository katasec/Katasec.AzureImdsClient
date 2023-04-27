using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class ManagedDisk
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}
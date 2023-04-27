using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;


public class Image
{
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

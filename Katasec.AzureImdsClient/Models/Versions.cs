using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class Versions
{
    [JsonPropertyName("apiVersions")]
    public List<string>? ApiVersions { get; set; }
}

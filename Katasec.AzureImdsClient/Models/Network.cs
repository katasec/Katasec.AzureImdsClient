using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class Network
{
    [JsonPropertyName("interface")]
    public Interface[]? Interface { get; set; }
}

public class Interface
{
    [JsonPropertyName("ipv4")]
    public Ipv4? Ipv4 { get; set; }

    [JsonPropertyName("ipv6")]
    public Ipv6? Ipv6 { get; set; }

    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; set; }
}

public class Ipv4
{
    [JsonPropertyName("ipAddress")]
    public IpAddress[]? IpAddress { get; set; }

    [JsonPropertyName("subnet")]
    public Subnet[]? Subnet { get; set; }
}

public class IpAddress
{
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }
}

public class Subnet
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

public class Ipv6
{
    [JsonPropertyName("ipAddress")]
    public string[]? IpAddress { get; set; }
}
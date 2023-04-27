using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class Loadbalancers
{
    [JsonPropertyName("loadbalancer")]
    public Loadbalancer? Loadbalancer { get; set; }
}


public partial class Loadbalancer
{
    [JsonPropertyName("publicIpAddresses")]
    public List<string>? PublicIpAddresses { get; set; }

    [JsonPropertyName("inboundRules")]
    public InboundRule[]? InboundRules { get; set; }

    [JsonPropertyName("outboundRules")]
    public object[]? OutboundRules { get; set; }
}


public partial class InboundRule
{
    [JsonPropertyName("frontendIpAddress")]
    public string? FrontendIpAddress { get; set; }

    [JsonPropertyName("protocol")]
    public Protocol Protocol { get; set; }

    [JsonPropertyName("frontendPort")]
    public long FrontendPort { get; set; }

    [JsonPropertyName("backendPort")]
    public long BackendPort { get; set; }

    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }
}

public enum Protocol { Tcp, Udp };
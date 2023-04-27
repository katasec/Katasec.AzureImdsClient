using System;
using System.Text.Json.Serialization;

namespace Katasec.AzureImdsClient.Models;

public class Metadata
{
    [JsonPropertyName("compute")]
    public Compute? Compute { get; set; }

    [JsonPropertyName("network")]
    public Network? Network { get; set; }
}

public class Compute
{
    [JsonPropertyName("azEnvironment")]
    public string? AzEnvironment { get; set; }

    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    [JsonPropertyName("isHostCompatibilityLayerVm")]
    public string? IsHostCompatibilityLayerVm { get; set; }

    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    [JsonPropertyName("osProfile")]
    public OsProfile? OsProfile { get; set; }

    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    [JsonPropertyName("placementGroupId")]
    public Guid? PlacementGroupId { get; set; }

    [JsonPropertyName("plan")]
    public Plan? Plan { get; set; }

    [JsonPropertyName("platformFaultDomain")]
    public string? PlatformFaultDomain { get; set; }

    [JsonPropertyName("platformUpdateDomain")]
    public string? PlatformUpdateDomain { get; set; }

    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    [JsonPropertyName("publicKeys")]
    public PublicKey[]? PublicKeys { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    [JsonPropertyName("securityProfile")]
    public SecurityProfile? SecurityProfile { get; set; }

    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    [JsonPropertyName("storageProfile")]
    public StorageProfile? StorageProfile { get; set; }

    [JsonPropertyName("subscriptionId")]
    public Guid SubscriptionId { get; set; }

    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    [JsonPropertyName("tagsList")]
    public TagsList[]? TagsList { get; set; }

    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("vmId")]
    public Guid VmId { get; set; }

    [JsonPropertyName("vmScaleSetName")]
    public string? VmScaleSetName { get; set; }

    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
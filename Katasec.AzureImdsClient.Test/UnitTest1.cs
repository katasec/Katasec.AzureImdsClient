
using Katasec.AzureImdsClient.Models;

namespace Katasec.AzureImdsClient.Test;

public class Tests
{
    AzureImdsApi api;
    Metadata metadata;

    public Tests()
    {
        var url = Environment.GetEnvironmentVariable("KATASEC_IMDS_URL");
        if (string.IsNullOrEmpty(url))
        {
            throw new Exception("Invalid IMDS API url");
        }
        api = new AzureImdsApi(url);
        metadata = api.GetMetadaInstance().Result;
    }

    [Test]
    public void GetResourceGroup()
    {
        Console.WriteLine(metadata.Compute?.ResourceGroupName);
    }

    [Test]
    public void GetResourceId()
    {
        Console.WriteLine(metadata.Compute?.ResourceId);
    }

    [Test]
    public void GetComputeName()
    {
        Console.WriteLine(metadata.Compute?.Name);
    }

    [Test]
    public void GetVersion()
    {
        var versions = api.GetVersions().Result;
        if (versions.ApiVersions != null)
        {
            foreach (var version in versions.ApiVersions)
            {
                Console.WriteLine(version);
            }
        }
    }


    [Test]
    public void GetLoadBalancer()
    {
        var loadbalancer = api.GetLoadBalancer().Result.Loadbalancer;

        if (loadbalancer != null && loadbalancer.InboundRules != null)
        {
            foreach (var rule in loadbalancer.InboundRules)
            {
                Console.WriteLine(rule.FrontendIpAddress);
                Console.WriteLine(rule.Protocol);
                Console.WriteLine(rule.FrontendPort);
                Console.WriteLine(rule.BackendPort);
                Console.WriteLine(rule.PrivateIpAddress);
                Console.WriteLine();
            }
        }
    }
}


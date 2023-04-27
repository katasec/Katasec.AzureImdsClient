
using Refit;
using System.ComponentModel;
using Katasec.AzureImdsClient;
using Katasec.AzureImdsClient.Models;
using System;
using System.Threading.Tasks;

namespace Katasec.AzureImdsClient;

public class AzureImdsApi
{
    private readonly IAzureImdsApi _api;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="url">URL to the metadat endpoint for e.g. http://169.254.169.254</param>
    public AzureImdsApi(string url="http://169.254.169.254")
    {
        try
        {
            new Uri(url);
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Invalid URL", nameof(url), ex);
        }   

        _api = RestService.For<IAzureImdsApi>(url);
    }
    public async Task<Metadata> GetMetadaInstance()
    {
        return await _api.GetMetadaInstance();
    }

    public async Task<Versions> GetVersions()
    {
        return await _api.GetVersions();
    }

    public async Task<Loadbalancers> GetLoadBalancer()
    {
        return await _api.GetLoadBalancer();
    }
}

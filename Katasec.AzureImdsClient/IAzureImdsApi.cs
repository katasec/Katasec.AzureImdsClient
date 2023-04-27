using Refit;
using Katasec.AzureImdsClient.Models;
using System.Threading.Tasks;

namespace Katasec.AzureImdsClient;

[Headers("Metadata: true")]
public interface IAzureImdsApi
{
    [Get("/metadata/instance?api-version={api_version}")]
    Task<Metadata> GetMetadaInstance([AliasAs("api_version")] string apiVersion= "2021-02-01");

    [Get("/metadata/versions")]
    Task<Versions> GetVersions();

    [Get("/metadata/loadbalancer?api-version={api_version}")]
    Task<Loadbalancers> GetLoadBalancer([AliasAs("api_version")] string apiVersion = "2021-02-01");
}



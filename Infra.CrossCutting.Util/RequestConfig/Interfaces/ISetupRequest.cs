

using RestSharp;

namespace Infra.CrossCutting.Util.RequestConfig.Interfaces
{
    public interface ISetupRequest
    {
        RestRequest MontarRequisicao(string Url, Method httpMethod);

        RestClient CriarRestClient();
    }
}

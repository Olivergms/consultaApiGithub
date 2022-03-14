using Infra.CrossCutting.Util.RequestConfig.Interfaces;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;


namespace Infra.CrossCutting.Util.RequestConfig.Servico
{
    public class SetupRequest : ISetupRequest
    {
        protected readonly IConfiguration _configuration;

        public SetupRequest(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public RestClient CriarRestClient()
        {
            var restClient = new RestClient(_configuration.GetSection("Api:Github:Url").Value);
            return restClient;
        }

        public RestRequest MontarRequisicao(string Url, Method httpMethod)
        {
            var request = new RestRequest
            {
                Method = httpMethod,
                Resource = Url
            };

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");

            return request;
        }
    }
}

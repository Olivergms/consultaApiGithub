using consultaApiGithub.Aplicacao.DTOs;
using consultaApiGithub.Aplicacao.Execoes;
using consultaApiGithub.Aplicacao.Interfaces;
using Infra.CrossCutting.Util.RequestConfig.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consultaApiGithub.Aplicacao.Servicos
{
    public class GithubServico : IGithubServico
    {
        readonly ISetupRequest _setupRequest;

        public GithubServico(ISetupRequest setupRequest)
        {
            _setupRequest = setupRequest;
        }

        public async Task<UsuarioDTO> ObterPerfil(string usuario)
        {
            if (string.IsNullOrEmpty(usuario)) throw new Exception("nome de usuário inválido.");


            var restCliente = _setupRequest.CriarRestClient();

            RestRequest request = _setupRequest.MontarRequisicao($"users/{usuario}", Method.Get);

            var response = await restCliente.ExecuteAsync(request);


            if (response.IsSuccessful)
            {
                var data = response.Content;
                return JsonConvert.DeserializeObject<UsuarioDTO>(data);                

            }
            else
            {
                throw new GithubException("Perfil não encontrado.");
            }
        }

        public Task<string> ObterRepositorios(string usuario)
        {
            throw new NotImplementedException();
        }
    }
}

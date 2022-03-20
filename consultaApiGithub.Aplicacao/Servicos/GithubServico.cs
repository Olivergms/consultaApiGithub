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

        public async Task<IEnumerable<RepositoriosDto>> ObterRepositorios(string usuario)
        {
            if (string.IsNullOrEmpty(usuario)) throw new Exception("nome de usuário inválido.");


            var restCliente = _setupRequest.CriarRestClient();

            RestRequest request = _setupRequest.MontarRequisicao($"users/{usuario}/repos", Method.Get);

            var response = await restCliente.ExecuteAsync(request);


            if (response.IsSuccessful)
            {
                var data = response.Content;
                return JsonConvert.DeserializeObject<IEnumerable<RepositoriosDto>>(data);

            }
            else
            {
                throw new GithubException($"Repositorios de {usuario} não encontrados");
            }
        }
    }
}

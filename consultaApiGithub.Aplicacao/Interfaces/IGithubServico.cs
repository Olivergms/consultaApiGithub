using consultaApiGithub.Aplicacao.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consultaApiGithub.Aplicacao.Interfaces
{
    public interface IGithubServico
    {
        Task<string> ObterRepositorios(string usuario);
        Task<UsuarioDTO> ObterPerfil(string usuario);
    }
}

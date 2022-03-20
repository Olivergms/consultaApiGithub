using consultaApiGithub.Aplicacao.DTOs;
using consultaApiGithub.Aplicacao.Execoes;
using consultaApiGithub.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace consultaApiGithub.Servicos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GithubController : Controller
    {
        private readonly IGithubServico _githubServico;

        public GithubController(IGithubServico githubServico)
        {
            _githubServico = githubServico;
        }

        [HttpGet("Usuarios/{usuario}")]
        public async Task<ActionResult<UsuarioDTO>> ObterPerfil(string usuario)
        {
            try
            {
                var perfil = await _githubServico.ObterPerfil(usuario);
                return StatusCode(StatusCodes.Status200OK, perfil);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }
        [HttpGet("Usuarios/{usuario}/Repositorios")]
        public async Task<ActionResult> ObterResitorios(string usuario)
        {
            try
            {
                var perfil = await _githubServico.ObterRepositorios(usuario);
                return StatusCode(StatusCodes.Status200OK, perfil);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

    }
}

using consultaApiGithub.Aplicacao.Interfaces;
using consultaApiGithub.Aplicacao.Servicos;
using Infra.CrossCutting.Util.RequestConfig.Interfaces;
using Infra.CrossCutting.Util.RequestConfig.Servico;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            RegistrarServicos(services);
        }

        static void RegistrarServicos(IServiceCollection services)
        {
            services.AddScoped<IGithubServico, GithubServico>();
            services.AddScoped<ISetupRequest, SetupRequest>();
        }
    }
}

using System;

namespace consultaApiGithub.Aplicacao.DTOs
{
    public class UsuarioDTO
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public int Public_repos { get; set; }
        public string Repos_url { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
        public string Url { get; set; }
        public string Html_Url { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

    }
}

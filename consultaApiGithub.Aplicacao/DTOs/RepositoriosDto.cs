using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consultaApiGithub.Aplicacao.DTOs
{
    public class RepositoriosDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Html_url { get; set; }
        public string Description { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public string Language { get; set; }
    }
}

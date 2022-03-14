using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace consultaApiGithub.Aplicacao.Execoes
{
    public class GithubException: Exception
    {
        public GithubException()
        {

        }
        public GithubException(string message) : base(message)
        {               
        }

        public GithubException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public GithubException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

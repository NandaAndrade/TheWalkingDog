using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWalkingDog.Gateway.Api.Models.Request
{
    public class CadastroDonoRequest
    {
        public string Nome { get; set; }
        public EnderecoRequest Endereco { get; set; }
    }
}

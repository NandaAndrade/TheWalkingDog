using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheWalkingDog.Gateway.Api.Models.Request
{
    public class EnderecoRequest
    {
        [Key]
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}

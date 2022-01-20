using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWalkingDog.Gateway.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CadastroController : ControllerBase
    {
        private readonly _IDonoRepository;

        public void CadastraDono(Dono dono)
        {

        }
    }
}

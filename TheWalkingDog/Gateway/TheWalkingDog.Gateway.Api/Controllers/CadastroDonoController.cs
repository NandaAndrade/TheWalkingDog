using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWalkingDog.Gateway.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CadastroDonoController : ControllerBase
    {
        //private readonly _IDonoRepository;

        [HttpPost]
        public void CadastraDono([FromBody]Dono dono)
        {

        }
    }
}

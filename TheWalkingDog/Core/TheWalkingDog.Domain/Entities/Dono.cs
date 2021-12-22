using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWalkingDog.Domain.Entities
{
    class Dono : IUsuario
    {
        public List<Cachorro> Cachorros { get; set; }
        public double Nota { get; set; }
    }
}

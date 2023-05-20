using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes.clases
{
    internal interface ISuperHeroes
    {
        public string Nombre { get; set; }
        public string Fuerza { get; set; }
        public void volar();
        public void salvarElMundo();
        public void presentarse();

    }
}

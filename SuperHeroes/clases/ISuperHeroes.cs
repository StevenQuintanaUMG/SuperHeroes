using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes.clases
{
    internal interface ISuperHeroes
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Fuerza { get; set; }
        public int agilidad { get; set; }
        public void volar();
        public void salvarElMundo();
        public void presentarse();

    }
}

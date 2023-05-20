using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes.clases
{
    internal class Superman : ISuperHeroes
    {
        string ISuperHeroes.Fuerza { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nombre { get; set; }
        public int Fuerza { get; set; }

        public void volar()
        {
            Console.WriteLine("Superman Vuela");
        }

        public void salvarElMundo()
        {
            Console.WriteLine("Superman salva el mundo");
        }

        public void presentarse()
        {
            Console.WriteLine("Hola soy superman");
        }


    }
}

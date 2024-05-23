using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Barco : Vehiculo
    {
        public override void Arrancar()
        {
            Console.WriteLine("EL barco arranca");
        }

        public override void Detener()
        {
            Console.WriteLine("El barco se detiene");
        }

        public override void Repostar()
        {
            Console.WriteLine("El barco recarga");
        }
    }
}

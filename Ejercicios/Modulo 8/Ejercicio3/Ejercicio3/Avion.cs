using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Avion : Vehiculo
    {
        public override void Arrancar()
        {
            Console.WriteLine("El avion arranca");
        }

        public override void Detener()
        {
            Console.WriteLine("El avion se detiene");
        }

        public override void Repostar()
        {
            Console.WriteLine("El avion se carga");
        }
    }
}

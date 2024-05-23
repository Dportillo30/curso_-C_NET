using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Coche : Vehiculo
    {
        public override void Arrancar()
        {
            Console.WriteLine("El coche arranca");
        }

        public override void Detener()
        {
            Console.WriteLine("El coche se detiene");
        }

        public override void Repostar()
        {
            Console.WriteLine("el coche se carga");
        }
    }
}

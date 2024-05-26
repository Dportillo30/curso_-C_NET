using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Localidad { get; set; }

        public Persona()
        {

        }

        public Persona(string nombre, int edad, string localidad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Localidad = localidad;
        }
    }
}

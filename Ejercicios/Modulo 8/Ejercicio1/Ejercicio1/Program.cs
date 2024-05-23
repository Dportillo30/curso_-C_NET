// See https://aka.ms/new-console-template for more information
using Ejercicio1;




List<Persona> personas = new List<Persona>();

int contador = 5;

while(contador > 0)
{
    Persona persona = new Persona();
    Console.WriteLine("Escribe un nombre");
    persona.Nombre = Console.ReadLine();
    Console.WriteLine("Escribe la edad ");
    persona.Edad = Convert.ToInt32(Console.ReadLine());
    personas.Add(persona);
    contador--;
}

validarMayores(personas);

void validarMayores(List<Persona> personas)
{
    foreach ( Persona persona in personas)
    {
        if(persona.Edad >= 18)
        {
            Console.WriteLine(persona.Nombre);
        }
    }
}



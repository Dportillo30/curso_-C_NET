// See https://aka.ms/new-console-template for more information





using Ejercicio2;

List<Persona> personas = new List<Persona>();

int contador = 5;

while (contador > 0)
{
    Console.WriteLine("Escribe un nombre");
    string nombre = Console.ReadLine();
    Console.WriteLine($"Ingrese el tipo de persona (alumno o profesor) para {nombre}:");
    string tipo = Console.ReadLine();
    Console.WriteLine("Escribe la edad ");
    int edad = Convert.ToInt32(Console.ReadLine());

    switch (tipo.ToLower())
    {
        case "alumno":
            Console.WriteLine($"Ingrese el número de alumno para {nombre}:");
            int numeroAlumno = int.Parse(Console.ReadLine());
            personas.Add(new Alumno(nombre, edad, numeroAlumno));
            contador--;
            break;
        case "profesor":
            Console.WriteLine($"Ingrese la materia que imparte {nombre}:");
            string materia = Console.ReadLine();
            personas.Add(new Profesor(nombre, edad, materia));
            contador--;
            break;
        default:
            Console.WriteLine("Tipo de persona no válido. Ingrese 'alumno' o 'profesor'.");
            break;
    }
   
}

validarMayores(personas);

void validarMayores(List<Persona> personas)
{
    foreach (Persona persona in personas)
    {
        if (persona.Edad >= 18)
        {
            Console.WriteLine($"{persona.Nombre} - {persona.GetType().Name}");
        }
    }
}



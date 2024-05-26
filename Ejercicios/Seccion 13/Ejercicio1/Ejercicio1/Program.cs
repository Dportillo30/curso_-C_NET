using Ejercicio1;
using System.IO;
using System.Text;

List<Persona> personas = new List<Persona>();
string nombre = string.Empty;
int edad = 1;
string localidad = string.Empty;

char continuar = 'S';

while (continuar != 'N')
{
    Console.WriteLine("Ingrese el nombre de una persona:");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la edad de una persona:");
    edad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese su localidad:");
    localidad = Console.ReadLine();
    Persona persona = new Persona(nombre, edad, localidad);
    Console.WriteLine("Desea agregar otra persona? S/N");

    using (FileStream file = ValidarArchivo())
    {
        string cadena = $"{persona.Nombre}|{persona.Edad}|{persona.Localidad};";
        byte[] data = Encoding.ASCII.GetBytes(cadena);
        file.Write(data, 0, data.Length);
    }

    continuar = Console.ReadKey().KeyChar;
    Console.WriteLine(); 
}

parseFileToPersona();

foreach (Persona persona in personas)
{
    Console.Write($"Nombre: {persona.Nombre}, ");
    Console.Write($"Edad: {persona.Edad}, ");
    Console.WriteLine($"Localidad: {persona.Localidad}.");
}

FileStream ValidarArchivo()
{
    string filePath = "C:/Users/danil/source/repos/Dportillo30/curso_-C_NET/Ejercicios/Seccion 13/Ejercicio1/Ejercicio1/bin/Debug/net6.0/personas.txt";
    if (File.Exists(filePath))
    {
        return new FileStream(filePath, FileMode.Append);
    }
    else
    {
        return new FileStream(filePath, FileMode.Create);
    }
}

void parseFileToPersona()
{
    string filePath = "C:/Users/danil/source/repos/Dportillo30/curso_-C_NET/Ejercicios/Seccion 13/Ejercicio1/Ejercicio1/bin/Debug/net6.0/personas.txt";
    if (File.Exists(filePath))
    {
        byte[] infoArchivo = File.ReadAllBytes(filePath);
        string parseData = Encoding.ASCII.GetString(infoArchivo);
        string[] segmentos = parseData.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string segmento in segmentos)
        {
            string[] parte = segmento.Split('|');
            if (parte.Length == 3)
            {
                string nombre = parte[0];
                if (int.TryParse(parte[1], out int edad) && !string.IsNullOrEmpty(parte[2]))
                {
                    string localidad = parte[2];
                    Persona persona = new Persona(nombre, edad, localidad);
                    personas.Add(persona);
                }
            }
        }
    }
}

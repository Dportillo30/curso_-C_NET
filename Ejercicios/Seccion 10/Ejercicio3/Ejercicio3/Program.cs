using System;

// Definir el enumerado
enum Animales
{
    perro = 5,
    gato = 8,
    canario = 2,
    caballo = 12
}

// Definir la clase Animal
class Animal
{
    public Animales Tipo { get; set; }
}

class Program
{
    static void Main()
    {
        // Pedir un número al usuario
        Console.Write("Introduce un número: ");
        int numero;
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            // Verificar si el número coincide con el valor de algún animal
            string nombreAnimal = ComprobarNumero(numero);
            if (nombreAnimal != null)
            {
                Console.WriteLine($"Ese valor pertenece al {nombreAnimal}.");
            }
            else
            {
                Console.WriteLine("No hay ningún animal con ese valor.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, introduce un número válido.");
        }
    }

    // Función para comprobar si el número coincide con el valor de algún animal
    static string ComprobarNumero(int numero)
    {
        foreach (Animales animal in Enum.GetValues(typeof(Animales)))
        {
            if ((int)animal == numero)
            {
                return animal.ToString();
            }
        }
        return null;
    }
}

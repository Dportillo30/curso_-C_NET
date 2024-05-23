using System;

// Definición de la interfaz IAnimal
public interface IAnimal
{
    void Andar();
    bool EsPerro();
    void Saltar();
}

// Implementación de la clase Animal que implementa la interfaz IAnimal
public class Animal : IAnimal
{
    public void Andar()
    {
        Console.WriteLine("El animal está andando.");
    }

    public bool EsPerro()
    {
        return false; // Por defecto, no es un perro
    }

    public void Saltar()
    {
        Console.WriteLine("El animal está saltando.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la clase Animal
        Animal animal = new Animal();

        // Llamar a los métodos de la interfaz IAnimal
        animal.Andar();
        Console.WriteLine("¿Es perro?: " + animal.EsPerro());
        animal.Saltar();
    }
}

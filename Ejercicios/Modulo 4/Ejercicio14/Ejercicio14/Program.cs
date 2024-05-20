using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa un número entero positivo:");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Variable para contar las cifras
        int cifras = 0;

        // Manejo especial si el número es 0
        if (numero == 0)
        {
            cifras = 1;
        }
        else
        {
            // Dividir repetidamente entre 10 y contar las divisiones
            while (numero != 0)
            {
                numero /= 10;
                cifras++;
            }
        }

        Console.WriteLine($"El número tiene {cifras} cifras.");
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Letras de la Z a la A:");
        for (char letra = 'Z'; letra >= 'A'; letra--)
        {
            Console.Write(letra + " ");
        }
    }
}

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa el dia de la semana:");
        string input = Console.ReadLine();
        switch (input?.ToLower())
        {
            case "lunes":
                Console.WriteLine("No es fin semana");
                break;

            case "martes":
                Console.WriteLine("No es fin semana");
                break;

            case "miercoles":
                Console.WriteLine("No es fin semana");
                break;

            case "jueves":
                Console.WriteLine("No es fin semana");
                break;

            case "viernes":
                Console.WriteLine("No es fin semana");
                break;

            case "sabado":
                Console.WriteLine("Si es fin de semana");
                break;

            case "domingo":
                Console.WriteLine("Si es fin de semana");
                break;
            default:
                Console.WriteLine("No es un dia de la semana");
                break;

        }
    }
}
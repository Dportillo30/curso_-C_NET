using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una letra o un número:");
        char caracter = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (EsNumero(caracter))
        {
            Console.WriteLine("Es un número.");
        }
        else if (EsVocal(caracter))
        {
            Console.WriteLine("Es una vocal.");
        }
        else if (EsConsonante(caracter))
        {
            Console.WriteLine("Es una consonante.");
        }
        else
        {
            Console.WriteLine("No es ni una vocal, ni una consonante, ni un número.");
        }

        static bool EsNumero(char caracter)
        {
            return char.IsDigit(caracter);
        }

        static bool EsVocal(char caracter)
        {
            caracter = char.ToLower(caracter);
            return caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u';
        }

        static bool EsConsonante(char caracter)
        {
            caracter = char.ToLower(caracter);
            return char.IsLetter(caracter) && !EsVocal(caracter);
        }
    }
}
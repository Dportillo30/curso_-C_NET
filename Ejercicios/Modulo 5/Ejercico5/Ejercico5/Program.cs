using System;

class Program
{
    static void Main()
    {
        int numero = 0;
        Console.WriteLine("Ingrese un numero para digitar su tabla:");
        numero = int.Parse(Console.ReadLine());

        for(int i = 0; i <= 12; i++)
        {
            Console.Write(i + " * " + numero + " = ");
            Console.WriteLine(numero * i);
        }
    }
}

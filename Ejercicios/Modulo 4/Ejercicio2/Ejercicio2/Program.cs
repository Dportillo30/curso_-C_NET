using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Ingrese el primer número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

       
        int mayor = (numero1 > numero2) ? numero1 : numero2;


        Console.WriteLine($"El número mayor es: {mayor}");
    }
}

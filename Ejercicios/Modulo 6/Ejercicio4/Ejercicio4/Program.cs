using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Ingresa el primer numero: " );
        int numero1= Convert.ToInt32(Console.ReadLine());

        StringBuilder sb = new StringBuilder("El primer numero introducido es ");

        sb.Append(numero1);

        Console.WriteLine("Ingresa el segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        sb.Append($", el segundo numero introducido es {numero2}");

        Console.WriteLine("Ingresa el tercer numero: ");
        int numero3 = Convert.ToInt32(Console.ReadLine());

        sb.Append($", el tercer numero introducido es {numero3}");


        Console.WriteLine("Ingresa el cuarto numero: ");
        int numero4 = Convert.ToInt32(Console.ReadLine());

        sb.Append($", el cuarto numero introducido es {numero4}");


        Console.WriteLine(sb.ToString());


    }
}
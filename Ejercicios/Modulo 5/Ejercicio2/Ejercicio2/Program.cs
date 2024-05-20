/*Crear una calculadora , usando funciones de suma, resta, multiplicación y división.*/

using System;

class Program
{
    static void Main()
    {

        int menu = 0;

        do
        {
            //menu
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicacion");
            Console.WriteLine("4.Divison");
            Console.WriteLine("5.Salir");

            menu = Convert.ToInt32(Console.ReadLine());

            double numero1 = 0;
            double numero2 = 0;
            double resultado = 0;

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Ingresa el primer numero:");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero:");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    resultado = suma(numero1, numero2);
                    Console.WriteLine("El resultado es:" + resultado);
                    break;
                case 2:
                    Console.WriteLine("Ingresa el primer numero:");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero:");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    resultado = resta(numero1, numero2);
                    Console.WriteLine("El resultado es:" + resultado);
                    break;
                case 3:
                    Console.WriteLine("Ingresa el primer numero:");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero:");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    resultado = multiplicacion(numero1, numero2);
                    Console.WriteLine("El resultado es:" + resultado);
                    break;
                case 4:
                    Console.WriteLine("Ingresa el primer numero:");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero:");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    resultado = division(numero1, numero2);
                    Console.WriteLine("El resultado es:" + resultado);
                    break;
                default:
                    Console.WriteLine("Ingresa una opcion valida!");
                    break;

            }
        } while (menu != 5);
    }

    static double suma(double numero1, double numero2)
    {
        return numero1 + numero2;
    }

    static double resta(double numero1, double numero2)
    {
        return numero1 - numero2;
    }

    static double multiplicacion(double numero1, double numero2)
    {
        return numero1 * numero2;
    }

    static double division(double numero1, double numero2)
    {
        return numero1 / numero2;
    }
}

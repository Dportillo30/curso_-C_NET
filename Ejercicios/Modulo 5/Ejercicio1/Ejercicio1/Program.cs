/*Hacer un programa que transforme entre dólares y 
 * euros y que también pida el tipo de cambio del día.*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cuanto es el cambio de 1$ a 1 Euro ?");
        double tasa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Cuantos $ desas convertir?");
        double monto = Convert.ToDouble(Console.ReadLine());

        double total = conversionDolaresAEuros(tasa, monto);

        Console.WriteLine("El total cambiado es:" + total.ToString("N2") + "Euros");

    }

    public static double conversionDolaresAEuros(double tasa, double monto)
    {
        double cambio = monto * tasa;
        return cambio;
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el importe a desglosar:");
        double importe = Convert.ToDouble(Console.ReadLine());

        DesglosarImporte(importe);
    }

    static void DesglosarImporte(double importe)
    {
        double[] valores = { 200, 100, 50, 20, 10, 1, 0.50, 0.25, 0.10, 0.05 };

        Console.WriteLine("Desglose del importe:");

        // Iterar sobre los valores de los billetes y monedas
        foreach (double valor in valores)
        {
            // Calcular la cantidad de billetes o monedas necesarios
            int cantidad = (int)(importe / valor);

            // Si se necesitan billetes o monedas de este valor, mostrar la cantidad
            if (cantidad > 0)
            {
                Console.WriteLine($"{cantidad} {(valor >= 1 ? "billete(s)" : "moneda(s)")} de {valor:C}");
            }

            // Actualizar el importe restante
            importe -= cantidad * valor;
        }
    }
}

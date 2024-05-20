using System;

class Program
{
    static void Main()
    {
        int numero = 1;
        int numeroMayor = int.MinValue;
        int numeroMenor = int.MaxValue;
        int cantidadNumeros = 0;

        while (numero != 0)
        {
            Console.WriteLine("Ingresa un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero != 0)
            {
                cantidadNumeros++;
                ActualizarExtremos(numero, ref numeroMayor, ref numeroMenor);
            }
        }

        int diferencia = CalcularDiferencia(numeroMayor, numeroMenor);
        Console.WriteLine($"Número más alto: {numeroMayor}");
        Console.WriteLine($"Número más bajo: {numeroMenor}");
        Console.WriteLine($"Diferencia entre el mayor y el menor: {diferencia}");
        Console.WriteLine($"Cantidad de números introducidos: {cantidadNumeros}");
    }

    static void ActualizarExtremos(int numero, ref int numeroMayor, ref int numeroMenor)
    {
        if (numero > numeroMayor)
        {
            numeroMayor = numero;
        }
        if (numero < numeroMenor)
        {
            numeroMenor = numero;
        }
    }

    static int CalcularDiferencia(int numeroMayor, int numeroMenor)
    {
        return numeroMayor - numeroMenor;
    }
}

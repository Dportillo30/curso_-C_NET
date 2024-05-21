using System.Collections.Generic;

List<int> numeros = new List<int>();

int contador = 10;
int sumaPares = 0;
int sumaImpares = 0;

while (contador > 0)
{
    Console.WriteLine("Ingese un numero");
    numeros.Add(Convert.ToInt32(Console.ReadLine()));
    contador--;
}

foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        sumaPares += numero;
    }
    else
    {
        sumaImpares += numero;
    }

    
}

Console.WriteLine($"Pares {sumaPares}");
Console.WriteLine($"Impares {sumaImpares}");
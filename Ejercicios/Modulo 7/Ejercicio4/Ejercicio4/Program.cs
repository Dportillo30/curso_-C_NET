int contador = 10;
List<int> numeros = new List<int>();
while (contador > 0)
{
    Console.WriteLine("Escribe un numero:");
    numeros.Add( Convert.ToInt32(Console.ReadLine()) );
    contador--;
}

int numeroMayor = numeros[0];
int numeroMenor = numeros[0];

foreach ( int numero in numeros)
{
    if(numero > numeroMayor)
    {
        numeroMayor = numero;
    }else if(numero < numeroMenor)
    {
        numeroMenor = numero;
    }
}

Console.WriteLine($"El numero mayor es {numeroMayor}");
Console.WriteLine($"El numero menor es {numeroMenor}");
int numero = 0;
bool esPrimo = true;

Console.WriteLine("Ingresa un numero:");
numero = Convert.ToInt32(Console.ReadLine());

if (numero <= 1)
{
    esPrimo = false; 
}
else
{
    for (int i = 2; i <= Math.Sqrt(numero); i++)
    {
        if (numero % i == 0)
        {
            esPrimo = false; 
            break;
        }
    }
}

if (esPrimo)
{
    Console.WriteLine("El número es primo");
}
else
{
    Console.WriteLine("El número no es primo");
}

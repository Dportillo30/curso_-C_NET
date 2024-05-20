int[] numeros = new int[10];
int total = 0;
for(int i =  0; i < 10; i++)
{
    Console.WriteLine("Ingresa un numero");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}


foreach(int numero in numeros)
{
   if(numero % 2 == 0) total+=numero;
   else total -= numero;
}
Console.WriteLine("El resultado es:" + total);
/*
 * Crea un programa que pida por consola un numero del 1 al 1000 
 * (validara que el numero introducido es correcto) y sume todos los números del 1 al numero introducido, 
 * mostrando por consola el numero de la suma y la media.
 */

int numero = 0;
int suma = 0;
double media;

while(numero<1 || numero > 1000)
{
    Console.WriteLine("Ingresa un numero del 1 al 1000:");
    numero = Convert.ToInt32(Console.ReadLine());
}

for(int i = 1;  i <= numero; i++)
{
    suma += i;
    
}
media = (double) suma / numero;
Console.WriteLine(suma);
Console.WriteLine(media);
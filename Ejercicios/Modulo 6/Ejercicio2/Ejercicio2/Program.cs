Console.WriteLine("Ingresa una palabra: ");
string palabra = Console.ReadLine();
for (int i = palabra.Length - 1;  i >= 0; i--)
{
    Console.Write(palabra[i]);
}

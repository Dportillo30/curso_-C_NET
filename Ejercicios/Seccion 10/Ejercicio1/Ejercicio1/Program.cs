Dictionary<int , string> diccionario = new Dictionary<int , string>();

int key = 1;
string value = string.Empty;
string cadena2 = string.Empty;

while(true)
{
    Console.WriteLine("Ingrese un numero para la llave: ");
    key = Convert.ToInt32(Console.ReadLine());

    if(key == 0)
    {
        break;
    }
    Console.WriteLine("Ingrese el valor para la llave: ");
    value = Console.ReadLine();
    diccionario.Add(key, value);

}

Console.Write("Introduce una cadena de 2 letras: ");
cadena2 = Console.ReadLine();

foreach (var kvp in diccionario)
{
    if (kvp.Value.Contains(cadena2)){
        Console.WriteLine(kvp.Key);
    }
}
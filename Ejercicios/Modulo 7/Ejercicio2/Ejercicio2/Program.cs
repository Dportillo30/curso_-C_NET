

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string>();

        int contador = 5;

        while (contador > 0)
        {
            Console.WriteLine("Ingesa un nombre");
            names.Add(Console.ReadLine());
            contador--;
        }

        Console.WriteLine("Ingrese un nombre a vadliar");

if (names.Contains(Console.ReadLine())){
            Console.WriteLine("Si existe el nombre");
        }
    }
}
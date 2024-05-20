internal class Program
{
    private static void Main(string[] args)
    {
        //name
        Console.Write("Escribe tu nombre:");
        var name = Console.ReadLine();

        //city
        Console.Write("Escribe tu ciudad:");
        var city = Console.ReadLine();

        //final output
        Console.WriteLine("Hola " + name + ", bienvenido a " + city);
    }
}
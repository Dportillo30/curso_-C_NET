public static class Producto
{
    public static int Sumar(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int resultado = Producto.Sumar(5, 3);
        Console.WriteLine("El resultado de la suma es: " + resultado);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        int valorProducto;
        string metodoDePago = "Efectivo";
        string noDeCuenta = "N/A";


        Console.WriteLine("Elija su metodo de pago! \n" + "1.Tarjeta \n" + "2.Efectivo \n");

        int menu;
        menu = Convert.ToInt32(Console.ReadLine());
        switch (menu)
        {
            case 1:
                metodoDePago = "Tarjeta";
                break;
            case 2:
                metodoDePago = "Efectivo";
                break;
            default:
                Console.WriteLine("Ingrese un metodo de pago valido!");
                break;
        }

        Console.WriteLine("Ingrese el valor del producto: ");

        valorProducto = Convert.ToInt32(Console.ReadLine());


        while (valorProducto < 0)
        {
            Console.WriteLine("El valor del producto debe ser positivo! Ingrese de nuevo el valor");
            valorProducto = Convert.ToInt32(Console.ReadLine());
        }

        if (menu == 1)
        {
            Console.WriteLine("Ingrese su No. de Cuenta");
            noDeCuenta = Console.ReadLine();
            
        }

        Console.WriteLine(
            "---RESUEMN ORDEN----\n" + 
            "Metodo de pago:" + metodoDePago + "\n" +
            "Valor del producto:" + valorProducto + "\n" +
            "No de Cuenta:" + noDeCuenta
            );
    }
}
public class Animal
{
    public string Tipo { get; set; }
    public string ColorPelo { get; set; }
    public bool EsDomestico { get; set; }
    public int NumeroPatas { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Creación de una instancia de la clase Animal y asignación de valores a sus propiedades
        Animal perro = new Animal
        {
            Tipo = "Perro",
            ColorPelo = "Marrón",
            EsDomestico = true,
            NumeroPatas = 4
        };

        // Mostrar los valores asignados a las propiedades del animal
        Console.WriteLine("Tipo de animal: " + perro.Tipo);
        Console.WriteLine("Color de pelo: " + perro.ColorPelo);
        Console.WriteLine("Es doméstico: " + perro.EsDomestico);
        Console.WriteLine("Número de patas: " + perro.NumeroPatas);
    }
}

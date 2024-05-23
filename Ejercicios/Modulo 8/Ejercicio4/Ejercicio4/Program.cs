public class Vehiculo
{
    private int _ruedas;
    private int _puertas;

    public Vehiculo()
    {
        _ruedas = 4;
        _puertas = 4;
    }

    public Vehiculo(int ruedas, int puertas)
    {
        _ruedas = ruedas;
        _puertas = puertas;
    }

    public Vehiculo(int ruedas)
    {
        _ruedas = ruedas;
        _puertas = 4;
    }

    public Vehiculo(string tipo)
    {
        if (tipo == "coche")
        {
            _ruedas = 4;
            _puertas = 4;
        }
        else if (tipo == "moto")
        {
            _ruedas = 2;
            _puertas = 0;
        }
        else
        {
            _ruedas = 0;
            _puertas = 0;
        }
    }

    public int ObtenerRuedas()
    {
        return _ruedas;
    }

    public int ObtenerPuertas()
    {
        return _puertas;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehiculo coche = new Vehiculo();
        Console.WriteLine("Coche - Ruedas: " + coche.ObtenerRuedas() + ", Puertas: " + coche.ObtenerPuertas());

        Vehiculo moto = new Vehiculo(2);
        Console.WriteLine("Moto - Ruedas: " + moto.ObtenerRuedas() + ", Puertas: " + moto.ObtenerPuertas());

        Vehiculo camion = new Vehiculo(6, 2);
        Console.WriteLine("Camión - Ruedas: " + camion.ObtenerRuedas() + ", Puertas: " + camion.ObtenerPuertas());

        Vehiculo avion = new Vehiculo("avion");
        Console.WriteLine("Avión - Ruedas: " + avion.ObtenerRuedas() + ", Puertas: " + avion.ObtenerPuertas());
    }
}

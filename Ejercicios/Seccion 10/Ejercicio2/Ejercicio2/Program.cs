using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var miClase = new MiClase<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "0")
            {
                break;
            }
            miClase.Agregar(input);
        }

        foreach (var item in miClase.ObtenerListado())
        {
            Console.WriteLine(item);
        }
    }
}

public class MiClase<T>
{
    private List<T> listado = new List<T>();

    public void Agregar(T valor)
    {
        listado.Add(valor);
    }

    public List<T> ObtenerListado()
    {
        return listado;
    }
}

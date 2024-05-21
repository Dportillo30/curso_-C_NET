using System;

class Program
{
    static void Main(string[] args)
    {
        string frase = PedirFrase();
        LongitudCadena(frase);
        ReemplazoAPorX(frase);
        CadenaMayusculas(frase);
        CadenaMinusculas(frase);
        MenosTresLetras(frase);
        PosicionCincoDiez(frase);
        InversionCadena(frase);
        NumeroPalabras(frase);
        TerceraPalabra(frase);


        
    }

    static string PedirFrase()
    {
        string frase;
        do
        {
            Console.WriteLine("Ingresa una frase de al menos 20 caracteres y al menos 4 palabras:");
            frase = Console.ReadLine().Trim();
        } while (!ValidarFrase(frase));

        return frase;
    }

    static bool ValidarFrase(string frase)
    {
        // Verificar que la cadena tenga al menos 20 caracteres
        if (frase.Length < 20)
        {
            Console.WriteLine("La frase debe tener al menos 20 caracteres.");
            return false;
        }

        // Verificar que la frase tenga al menos 4 palabras
        string[] palabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (palabras.Length < 4)
        {
            Console.WriteLine("La frase debe tener al menos 4 palabras.");
            return false;
        }

        return true;
    }

    static void LongitudCadena(string frase)
    {
       Console.WriteLine($"La longitud de la cadena es de {frase.Length}");
    }

    static void ReemplazoAPorX(string frase)
    {
        frase = frase.Replace("a", "x").Replace("A", "X");
        Console.WriteLine(frase);
    }

    static void CadenaMayusculas(string frase)
    {
        Console.WriteLine(frase.ToUpper());
    }

    static void CadenaMinusculas(string frase)
    {
        Console.WriteLine(frase.ToLower());
    }

    static void MenosTresLetras(string frase)
    {
        Console.WriteLine(frase.Substring(3, frase.Length - 3));
    }

    static void PosicionCincoDiez(string frase)
    {
        Console.WriteLine(frase.Substring(5, 10));
    }

    static void InversionCadena (string frase)
    {
        for(int i = frase.Length -1 ; i >= 0; i--)
        {
            Console.Write(frase[i]);
        }
        Console.WriteLine();
    }

    static void NumeroPalabras(string frase)
    {
        string[] palabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(palabras.Length);
    }

    static void TerceraPalabra(string frase)
    {
        string[] palabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"La tercera palabra es: {palabras[2]}");
    }


}

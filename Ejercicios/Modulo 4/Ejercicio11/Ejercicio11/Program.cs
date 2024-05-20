using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número del 1 al 7:");
        int numeroDia = Convert.ToInt32(Console.ReadLine());

        string diaSemana;

        switch (numeroDia)
        {
            case 1:
                diaSemana = "Lunes";
                break;
            case 2:
                diaSemana = "Martes";
                break;
            case 3:
                diaSemana = "Miércoles";
                break;
            case 4:
                diaSemana = "Jueves";
                break;
            case 5:
                diaSemana = "Viernes";
                break;
            case 6:
                diaSemana = "Sábado";
                break;
            case 7:
                diaSemana = "Domingo";
                break;
            default:
                diaSemana = "Día inválido";
                break;
        }

        Console.WriteLine($"El día de la semana correspondiente al número {numeroDia} es: {diaSemana}");
    }
}

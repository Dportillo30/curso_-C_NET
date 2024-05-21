using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de elementos del array: ");
        int cantidadElementos = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[cantidadElementos];

        
        for (int i = 0; i < cantidadElementos; i++)
        {
            Console.Write($"Ingrese el valor para el elemento {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        Console.Write("Ingrese el nuevo valor a insertar: ");
        int nuevoValor = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la posición donde desea insertar el nuevo valor (entre 0 y {0}): ", cantidadElementos);
        int posicion = Convert.ToInt32(Console.ReadLine());

        
        if (posicion < 0 || posicion > cantidadElementos)
        {
            Console.WriteLine("Posición inválida. Debe estar entre 0 y {0}.", cantidadElementos);
        }
        else
        {
           
            int[] nuevoArray = new int[cantidadElementos + 1];

            for (int i = 0; i < posicion; i++)
            {
                nuevoArray[i] = array[i];
            }

      
            nuevoArray[posicion] = nuevoValor;

            for (int i = posicion; i < cantidadElementos; i++)
            {
                nuevoArray[i + 1] = array[i];
            }


            Console.WriteLine("\nEl nuevo array con el valor insertado es:");
            for (int i = 0; i < nuevoArray.Length; i++)
            {
                Console.WriteLine($"Elemento {i}: {nuevoArray[i]}");
            }
        }
    }
}

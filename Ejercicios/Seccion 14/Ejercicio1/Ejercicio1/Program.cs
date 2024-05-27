using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Ingrediente
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Unidad { get; set; }
    }

    public class Receta
    {
        public string Nombre { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public List<string> Pasos { get; set; }

        public Receta()
        {
            Ingredientes = new List<Ingrediente>();
            Pasos = new List<string>();
        }

        public async Task Preparar()
        {
            foreach (var paso in Pasos)
            {
                await EjecutarPaso(paso);
            }
        }

        private Task EjecutarPaso(string paso)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"Ejecutando paso: {paso}");
                Task.Delay(1000).Wait();
            });
        }
    }

    public class Programa
    {
        public static async Task Main(string[] args)
        {
            var receta = new Receta
            {
                Nombre = "Tortilla de Patatas",
                Ingredientes = new List<Ingrediente>
                {
                    new Ingrediente { Nombre = "Patatas", Cantidad = 4, Unidad = "unidades" },
                    new Ingrediente { Nombre = "Huevos", Cantidad = 6, Unidad = "unidades" },
                    new Ingrediente { Nombre = "Cebolla", Cantidad = 1, Unidad = "unidad" },
                    new Ingrediente { Nombre = "Aceite de Oliva", Cantidad = 100, Unidad = "ml" },
                    new Ingrediente { Nombre = "Sal", Cantidad = 1, Unidad = "cucharadita" }
                },
                Pasos = new List<string>
                {
                    "Pelar y cortar las patatas y la cebolla",
                    "Freír las patatas y la cebolla en aceite de oliva",
                    "Batir los huevos en un bol grande",
                    "Añadir las patatas y la cebolla fritas al bol con los huevos",
                    "Mezclar bien y sazonar con sal",
                    "Calentar una sartén con un poco de aceite de oliva",
                    "Verter la mezcla en la sartén y cocinar a fuego medio",
                    "Dar la vuelta a la tortilla y cocinar el otro lado",
                    "Servir la tortilla caliente"
                }
            };

            await receta.Preparar();
        }
    }
}

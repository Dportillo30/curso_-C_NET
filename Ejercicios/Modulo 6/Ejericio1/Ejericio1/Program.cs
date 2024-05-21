Console.WriteLine("Ingresa tu nombre: ");
string nombre = Console.ReadLine().ToLower();
Console.WriteLine(nombre.Contains("alejandro") ? "Hola" : "No te conozco");

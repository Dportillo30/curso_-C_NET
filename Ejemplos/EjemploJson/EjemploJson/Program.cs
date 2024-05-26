
using Newtonsoft.Json;
using System.Net;



using EjemploJson;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            HttpWebRequest request = WebRequest.Create(@"https://jsonplaceholder.typicode.com/todos") as HttpWebRequest;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                var todos = JsonConvert.DeserializeObject<List<Todos>>(json);
                Console.WriteLine(todos.First().title);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
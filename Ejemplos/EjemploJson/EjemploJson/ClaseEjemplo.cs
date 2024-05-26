

namespace EjemploJson;

public class EjemploClase
{
    public List<Todos> Data { get; set; }
}

public class Todos
{
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public bool completed { get; set; }
}

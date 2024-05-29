namespace MinimalAPICRUD.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? ISBN { get; set; }

        public record BookRequest(string name , string isbn);
    }
}

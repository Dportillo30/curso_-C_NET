using MinimalAPICRUD.Models;
using static MinimalAPICRUD.Models.Book;

namespace MinimalAPICRUD.Services.Interfaces
{
    public interface IBookService
    {
        Task<Book> CrearLibro(BookRequest request);
    }
}

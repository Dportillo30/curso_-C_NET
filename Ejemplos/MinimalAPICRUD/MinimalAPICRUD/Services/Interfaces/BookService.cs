using MinimalAPICRUD.Context;
using MinimalAPICRUD.Models;
using static MinimalAPICRUD.Models.Book;

namespace MinimalAPICRUD.Services.Interfaces
{
    public class BookService : IBookService
    {
        private readonly APIContext _context;

        public BookService(APIContext context)
        {
            _context = context;
        }

        public async Task<Book> CrearLibro(BookRequest request)
        {
            var book = new Book
            {
                Name = request.name ?? string.Empty,
                ISBN = request.isbn ?? string.Empty,
            };

            var createBook = await _context.BookEntity.AddAsync(book);

            await _context.SaveChangesAsync();

            return createBook.Entity;
        }
    }
}

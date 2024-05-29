using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using MinimalAPICRUD.Context;
using MinimalAPICRUD.Services.Interfaces;
using static MinimalAPICRUD.Models.Book;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("BooksConnection") ??  "Data Source=Book.db";

builder.Services.AddDbContext<APIContext>(options => options.UseSqlite(connectionString));


//builder.Services.AddDbContext<APIContext>(options => options.UseInMemoryDatabase("api"));
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CRUD Minimal API", Description = "Ejemplo CRUD con MinimalAPI" });
});


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json" , "TODO API V1");
});

app.MapGet("/api/books" , async (APIContext context) => Results.Ok(await context.BookEntity.ToListAsync()));

app.MapGet("/api/books/{id}" , async (int id, APIContext context) =>
{
    var book = await context.BookEntity.FindAsync(id);
    if(book != null)
    {
        Results.Ok(book);
    }

    Results.NotFound();
});

app.MapPost("api/books", async(BookRequest request, IBookService bookservice) =>
{
    var createBook = await bookservice.CrearLibro(request);

    return Results.Created($"/books/{createBook.Id}",createBook);
});

app.MapDelete("/api/books/{id}", async (int id, APIContext context) =>
{
    var book = await context.BookEntity.FindAsync(id);
    if(book is null)
    {
        return Results.NotFound();
    }

    context.BookEntity.Remove(book);
    await context.SaveChangesAsync();

    return Results.NoContent();
});


app.MapPut("api/books/{id}", async (int id, BookRequest request ,APIContext context) =>
{
    var book = await context.BookEntity.FindAsync(id);
    if (book is null)
    {
        return Results.NotFound();
    }

    if(request.name !=  null)
    {
        book.Name = request.name;
    }
    if(request.isbn != null)
    {
        book.ISBN = request.isbn;
    }

    await context.SaveChangesAsync();

    return Results.Ok(book);
});
app.Run();

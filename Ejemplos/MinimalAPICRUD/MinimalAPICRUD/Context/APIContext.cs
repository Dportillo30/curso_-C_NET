using Microsoft.EntityFrameworkCore;
using MinimalAPICRUD.Models;

namespace MinimalAPICRUD.Context
{
    public class APIContext : DbContext
    {
        public DbSet<Book> BookEntity { get; set; }

        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity => entity.Property(p => p.ISBN).IsRequired());
        }
    }
}

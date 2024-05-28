using EntityFramework2Example.EntityConfig;
using EntityFramework2Example.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework2Example.Contexto
{
    public class ContextoDB : DbContext , IContextoDB
    {
        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
        {

        }

        public DbSet<Cancion> Canciones { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            CancionEntityConfig.SetCancionEntityConfig(modelBuilder.Entity<Cancion>());

            //modelBuilder.Entity<Cancion>().ToTable("Canciones");
            
        }
    }
}

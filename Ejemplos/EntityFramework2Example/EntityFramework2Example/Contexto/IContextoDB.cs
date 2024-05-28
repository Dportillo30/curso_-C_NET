using EntityFramework2Example.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Threading;

namespace EntityFramework2Example.Contexto
{
    public interface IContextoDB
    {

        DbSet<Cancion> Canciones { get; set; }

        DbSet<Album> Albums { get; set; }
        DbSet<Author> Authors { get; set; }


        int SaveChanges();

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}

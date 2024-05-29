using api.core.ejemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace api.core.ejemplo.DataAccess
{
    public class BBDDContext : DbContext , IDataAccess
    {
        public BBDDContext(DbContextOptions<BBDDContext> options) : base(options)
        {
            
        }

        public DbSet<ModelItem> ModelItem { get; set; }
    }
}

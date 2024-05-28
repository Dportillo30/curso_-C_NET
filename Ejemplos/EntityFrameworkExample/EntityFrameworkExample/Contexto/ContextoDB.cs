using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExample.Contexto
{
    public class ContextoDB : DbContext
    {
        public ContextoDB(DbContextOptions <ContextoDB> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}

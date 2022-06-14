using Microsoft.EntityFrameworkCore;
using prjViagem.Infrastructure.Entities;

namespace prjViagem.Infrastructure.Connections
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Viagem> Viagem { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
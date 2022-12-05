using Ciberinfraestructura_alumnos.Models;
using Microsoft.EntityFrameworkCore;

namespace Ciberinfraestructura_alumnos.DataAccess
{
    public class PostgreSqlContext : DbContext
    {
        public DbSet<catalumnos> catalumnos { get; set; }
        
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options) { 
        }

        protected override void OnModelCreating(ModelBuilder builder)  {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();

        }
    }
}

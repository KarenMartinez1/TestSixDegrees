using System.Data.Entity;
using TestSixDegrees.Domain;
using TestSixDegrees.Persistance.Configurations;

namespace TestSixDegrees.Persistance
{
    public class PruebaSDDbContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<Usuario>());
            base.OnModelCreating(modelBuilder);
        }
    }
}

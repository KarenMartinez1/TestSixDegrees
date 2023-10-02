using System.Data.Entity;

namespace ClassLibrary1
{
    public class PruebaDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}

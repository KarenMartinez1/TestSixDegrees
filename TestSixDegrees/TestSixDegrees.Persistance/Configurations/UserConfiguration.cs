using System.Data.Entity.ModelConfiguration;
using TestSixDegrees.Domain;

namespace TestSixDegrees.Persistance.Configurations
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeConfiguration<Usuario> entityBuilder)
        {
            entityBuilder.HasKey(x => x.UsuID);
            entityBuilder.Property(x => x.UsuID).HasPrecision(18, 0);
            entityBuilder.Property(x => x.Nombre).HasMaxLength(100);
            entityBuilder.Property(x => x.Apellido).HasMaxLength(100);
            
        }
    }
}

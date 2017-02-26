using System.Data.Entity.ModelConfiguration;
using WebForLink.Domain.Entities;

namespace WebForLink.Win.Banco
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Login)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("WFL_USUARIO");
            Property(t => t.Id).HasColumnName("Id");
            //Property(t => t.Login).HasColumnName("Login");
        }
    }
}
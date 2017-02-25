using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                .HasColumnType(columnType:"varchar")
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("WFL_USUARIO");
            Property(t => t.Id).HasColumnName("Id");
            //Property(t => t.Login).HasColumnName("Login");
        }
    }
}

using System.Data.Entity.ModelConfiguration;
using WebForLink.Domain.Entities;

namespace WebForLink.Win.Banco
{
    public class AplicacaoMap : EntityTypeConfiguration<Aplicacao>
    {
        public AplicacaoMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            //Property(t => t.Login)
            //    .IsRequired()
            //    .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("WFL_APLICACAO");
            Property(t => t.Id).HasColumnName("Id");
            //Property(t => t.Login).HasColumnName("Login");
        }
    }
}
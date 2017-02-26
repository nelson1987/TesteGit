using System.Data.Entity.ModelConfiguration;
using WebForLink.Domain.Entities;

namespace WebForLink.Win.Banco
{
    public class EmpresaMap : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
        {
            // Primary Key
            HasKey(t => t.Id);
            // Properties
            Property(t => t.RazaoSocial)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            ToTable("WFL_EMPRESA");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.RazaoSocial).HasColumnName("RazaoSocial");
            //Property(t => t.Login).HasColumnName("Login");

            //Mapeamento de Herança
            Map<Cliente>(m => m.Requires("Tipo").HasValue(1));
            Map<Fornecedor>(m => m.Requires("Tipo").HasValue(2));
            Map<Fabricante>(m => m.Requires("Tipo").HasValue(3));
        }
    }
}
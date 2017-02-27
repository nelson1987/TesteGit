using System.Data.Entity.ModelConfiguration;
using WebForLink.Domain.Entities;

namespace WebForLink.Win.Banco
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            //Map(m => m.Requires("Tipo").HasValue(1));
            //ToTable("WFL_CLIENTE");
            HasMany(t => t.Fornecedores)
                .WithMany(x => x.Clientes);
            HasMany(t => t.Fabricantes)
                .WithMany(x => x.Clientes);
        }
    }

    public class FornededorMap : EntityTypeConfiguration<Fornecedor>
    {
        public FornededorMap()
        {
            //Map(m => m.Requires("Tipo").HasValue(2));
            //ToTable("WFL_FORNECEDOR");
            HasMany(t => t.Clientes)
                .WithMany(x => x.Fornecedores);
            HasMany(t => t.Fabricantes)
                .WithMany(x => x.Fornecedores);
        }
    }

    public class FabricanteMap : EntityTypeConfiguration<Fabricante>
    {
        public FabricanteMap()
        {
            //Map(m => m.Requires("Tipo").HasValue(3));
            //ToTable("WFL_FABRICANTE");
            HasMany(t => t.Clientes)
                .WithMany(x => x.Fabricantes);
            HasMany(t => t.Fornecedores)
                .WithMany(x => x.Fabricantes);
        }
    }
}
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using WebForLink.Domain.Entities;
using WebForLink.Win.Banco;

namespace WebForLink.Win.Contexto
{
    public class WebForLinkContext : DbContext
    {
        static WebForLinkContext()
        {
            Database.SetInitializer<WebForLinkContext>(null);
        }

        public WebForLinkContext()
            : base("FinancasContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            // Log all the database calls when in Debug.
            Database.Log = message => Debug.Write(message);
        }

        public DbSet<Aplicacao> Aplicacao { get; set; }
        public DbSet<Contratante> Contratante { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Solicitacao> Solicitacao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Pluraliza de Tabelas
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //Deletar em cascata
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>(); //Deletar em cascata

            modelBuilder.Properties()
                .Where(p => p.Name.Equals("Id"))
                .Configure(p => p.IsKey());
            modelBuilder.Properties()
                .Where(p => p.Name.Equals("Id"))
                .Configure(x => x.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar")
                    .HasMaxLength(255));

            modelBuilder.Configurations.Add(new AplicacaoMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new EmpresaMap());
        }
    }
}
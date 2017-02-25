using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DbSet<Contratante> Contratantes { get; set; }

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
                //.Where(p => p.Name.StartsWith("Id"))
                .Where(p => p.Name.Equals("Id"))
                .Configure(p => p.IsKey());

            modelBuilder.Configurations.Add(new AplicacaoMap());
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class ContratanteTests
    {
        public Contratante Samarco;

        [TestInitialize]
        public void SetUp()
        {
            Samarco = new Contratante("Samarco");
        }

        [TestMethod]
        public void CriarContratante()
        {
            Assert.AreEqual(Samarco.RazaoSocial, "Samarco");
            Assert.AreEqual(Samarco.EmpresasCadastradas.Count, 0);
        }

        [TestMethod]
        public void AdicionarEmpresaAUmContratante()
        {
            Empresa sorteq = new Fornecedor("Sorteq", "12345678900", new TipoEmpresa("Fornecedor"));
            Assert.AreEqual(Samarco.EmpresasCadastradas.Count, 0);
            Samarco.AdicionarEmpresa(sorteq);
            Assert.AreEqual(Samarco.EmpresasCadastradas.Count, 1);
        }

        [TestMethod]
        public void ValidarEmpresaContratanteEFornecedorIndividual()
        {
            var fornecedorIndividual = new TipoContratante("Fornecedor Individual");
            Samarco = new Contratante("Samarco", fornecedorIndividual);
            Cliente samarcoDados = new Cliente("Samarco", "12345678900", new TipoEmpresa("Fornecedor"));
            Samarco.SetDadosGerais(samarcoDados);
            Assert.AreEqual(Samarco.DadosGerais.RazaoSocial, samarcoDados.RazaoSocial);
            Assert.AreEqual(Samarco.TipoContratante.Nome, "Fornecedor Individual");
        }

        [TestMethod]
        public void ValidarEmpresaContratanteEClienteAncora()
        {
            var clienteAncora = new TipoContratante("Cliente Ancora");
            var samarco = new Contratante("Samarco", clienteAncora);
            Cliente samarcoDados = new Cliente("Samarco", "12345678900", new TipoEmpresa("Fornecedor"));
            samarco.SetDadosGerais(samarcoDados);
            Assert.AreEqual(samarco.DadosGerais.RazaoSocial, samarcoDados.RazaoSocial);
            Assert.AreEqual(samarco.TipoContratante.Nome, "Cliente Ancora");
        }
    }
}
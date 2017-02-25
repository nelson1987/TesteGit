using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class ContratanteTests
    {
        [TestMethod]
        public void CriarContratante()
        {
            var samarco = new Contratante("Samarco");
            Assert.AreEqual(samarco.RazaoSocial, "Samarco");
            Assert.AreEqual(samarco.EmpresasCadastradas.Count, 0);
        }

        [TestMethod]
        public void AdicionarEmpresaAUmContratante()
        {
            var samarco = new Contratante("Samarco");
            var sorteq = new Empresa("Sorteq", "12345678900");
            Assert.AreEqual(samarco.EmpresasCadastradas.Count, 0);
            samarco.AdicionarEmpresa(sorteq);
            Assert.AreEqual(samarco.EmpresasCadastradas.Count, 1);
        }

        [TestMethod]
        public void ValidarEmpresaContratanteEFornecedorIndividual()
        {
            var fornecedorIndividual = new TipoContratante("Fornecedor Individual");
            var samarco = new Contratante("Samarco", fornecedorIndividual);
            var samarcoDados = new Empresa("Samarco", "12345678900");
            samarco.SetDadosGerais(samarcoDados);
            Assert.AreEqual(samarco.DadosGerais.RazaoSocial, samarcoDados.RazaoSocial);
            Assert.AreEqual(samarco.TipoContratante.Nome, "Fornecedor Individual");
        }

        [TestMethod]
        public void ValidarEmpresaContratanteEClienteAncora()
        {
            var clienteAncora = new TipoContratante("Cliente Ancora");
            var samarco = new Contratante("Samarco", clienteAncora);
            var samarcoDados = new Empresa("Samarco", "12345678900");
            samarco.SetDadosGerais(samarcoDados);
            Assert.AreEqual(samarco.DadosGerais.RazaoSocial, samarcoDados.RazaoSocial);
            Assert.AreEqual(samarco.TipoContratante.Nome, "Fornecedor Individual");
        }
    }
}
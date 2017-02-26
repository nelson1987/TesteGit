using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Entities.Tipos;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class ContratanteTests
    {
        private Contratante Samarco;

        [TestInitialize]
        public void SetUp()
        {
            Samarco = new Contratante("Samarco", new ClienteContratante());
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
            Empresa sorteq = new Fornecedor("Sorteq", "12345678900", new EmpressaPessoaJuridica());
            // new TipoEmpresa("Fornecedor"));
            Assert.AreEqual(Samarco.EmpresasCadastradas.Count, 0);
            Samarco.AdicionarEmpresa(sorteq);
            Assert.AreEqual(Samarco.EmpresasCadastradas.Count, 1);
        }

        [TestMethod]
        public void ValidarEmpresaContratanteEFornecedorIndividual()
        {
            TipoContratante fornecedorIndividual = new FornecedorContratante();
            Samarco = new Contratante("Samarco", fornecedorIndividual);
            var samarcoDados = new Cliente("Samarco", "12345678900", new EmpressaPessoaJuridica());
            //new TipoEmpresa("Fornecedor"));
            Samarco.SetDadosGerais(samarcoDados);
            Assert.AreEqual(Samarco.DadosGerais.RazaoSocial, samarcoDados.RazaoSocial);
            Assert.AreEqual(Samarco.TipoContratante.Nome, "Fornecedor Individual");
        }

        [TestMethod]
        public void ValidarEmpresaContratanteEClienteAncora()
        {
            TipoContratante clienteAncora = new ClienteContratante();
            var samarco = new Contratante("Samarco", clienteAncora);
            var samarcoDados = new Cliente("Samarco", "12345678900", new EmpressaPessoaJuridica());
            //new TipoEmpresa("Fornecedor"));
            samarco.SetDadosGerais(samarcoDados);
            Assert.AreEqual(samarco.DadosGerais.RazaoSocial, samarcoDados.RazaoSocial);
            Assert.AreEqual(samarco.TipoContratante.Nome, "Cliente Âncora");
        }
    }
}
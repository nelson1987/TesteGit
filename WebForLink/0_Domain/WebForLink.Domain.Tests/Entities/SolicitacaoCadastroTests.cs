using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class SolicitacaoCadastroTests
    {
        private Usuario nelson;
        private TipoEmpresa pessoaJuridica;
        private Contratante samarco;
        private Empresa sorteq;

        [TestInitialize]
        public void SetUp()
        {
            samarco = new Contratante("Samarco");
            nelson = new Usuario("nelson.neto", samarco);
            pessoaJuridica = new TipoEmpresa("Pessoa Jurídica");
            sorteq = new Empresa("Sorteq", "12345678900", pessoaJuridica);
        }

        [TestMethod]
        public void CriarSolicitacaoDeCadastro()
        {
            Solicitacao solicitacaoDeCadastro = new TipoSolicitacaoCadastro(nelson, sorteq);
            Assert.AreEqual(solicitacaoDeCadastro.Tipo.Descricao, "Cadastro de Pessoa Jurídica");
        }

        [TestMethod]
        public void CriarSolicitacaoDeFornecedorComFluxo()
        {
            Solicitacao solicitacaoDeCadastro = new TipoSolicitacaoCadastro(nelson, sorteq);
            var cadastroFornecedor = new TipoFluxo("Cadastro de Fornecedor");
            var cadastroDeFornecedor = new Fluxo(cadastroFornecedor, samarco, pessoaJuridica);
            solicitacaoDeCadastro.Tipo.SetFluxo(cadastroDeFornecedor);
            cadastroDeFornecedor.AdicionarEtapas(new Etapa("Solicitacao"), new Etapa("MDA"), new Etapa("Conclusão"));
            Assert.AreEqual(cadastroDeFornecedor.EtapaAtual.Nome, "Solicitacao");
            Assert.AreEqual(solicitacaoDeCadastro.Tipo.Fluxo.EtapaAtual.Nome, "Solicitacao");
        }
    }
}
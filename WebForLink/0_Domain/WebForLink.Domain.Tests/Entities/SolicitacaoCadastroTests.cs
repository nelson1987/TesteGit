using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Entities.Tipos;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class SolicitacaoCadastroTests
    {
        private Usuario _nelson;
        private TipoEmpresa _pessoaJuridica;
        private Contratante _samarco;
        private Empresa _sorteq;
        private Aplicacao _webForLink;

        [TestInitialize]
        public void SetUp()
        {
            _webForLink = new Aplicacao("WebForLink", "Cadastro de Fornecedores");
            _samarco = new Contratante("Samarco");
            _nelson = new Usuario("nelson.neto", _webForLink, _samarco);
            _pessoaJuridica = new TipoEmpresa("Pessoa Jurídica");
            _sorteq = new Fornecedor("Sorteq", "12345678900", _pessoaJuridica);
        }

        [TestMethod]
        public void CriarSolicitacaoDeCadastro()
        {
            Solicitacao solicitacaoDeCadastro = new TipoSolicitacaoCadastro(_nelson, _sorteq);
            Assert.AreEqual(solicitacaoDeCadastro.Tipo.Descricao, "Cadastro de Pessoa Jurídica");
        }

        [TestMethod]
        public void CriarSolicitacaoDeFornecedorComFluxo()
        {
            Solicitacao solicitacaoDeCadastro = new TipoSolicitacaoCadastro(_nelson, _sorteq);
            var cadastroFornecedor = new TipoFluxo("Cadastro de Fornecedor");
            var cadastroDeFornecedor = new Fluxo(cadastroFornecedor, _samarco, _pessoaJuridica);
            solicitacaoDeCadastro.Tipo.SetFluxo(cadastroDeFornecedor);
            cadastroDeFornecedor.AdicionarEtapas(new Etapa("Solicitacao"), new Etapa("MDA"), new Etapa("Conclusão"));
            Assert.AreEqual(cadastroDeFornecedor.EtapaAtual.Nome, "Solicitacao");
            Assert.AreEqual(solicitacaoDeCadastro.Tipo.Fluxo.EtapaAtual.Nome, "Solicitacao");
        }
    }
}
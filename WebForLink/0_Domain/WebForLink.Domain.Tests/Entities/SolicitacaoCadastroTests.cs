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
            _samarco = new Contratante("Samarco", new ClienteContratante());
            _nelson = new Usuario("nelson.neto", _webForLink, _samarco);
            _pessoaJuridica = new EmpressaPessoaJuridica(); //new TipoEmpresa("Pessoa Jurídica");
            _sorteq = new Fornecedor("Sorteq", "12345678900", _pessoaJuridica);
        }

        [TestMethod]
        public void CriarSolicitacaoDeCadastro()
        {
            Solicitacao solicitacaoDeCadastro = new SolicitacaoCadastro(_nelson, _sorteq);
            //Assert.AreEqual(solicitacaoDeCadastro.Tipo.Descricao, "Cadastro de Pessoa Jurídica");
        }

        [TestMethod]
        public void CriarSolicitacaoDeFornecedorComFluxo()
        {
            var webForLink = new Aplicacao("WebForLink", "Cadastro De Fornecedores");
            TipoContratante clienteAncora = new ClienteContratante();
            var samarco = new Contratante("Samarco", clienteAncora);
            var nelson = new Usuario("nelson", webForLink, samarco);
            TipoEmpresa pessoaJuridica = new EmpressaPessoaJuridica();
            Empresa sorteq = new Fornecedor("Sorteq", "12345678900", pessoaJuridica);
            Solicitacao solicitacaoCadastro = new SolicitacaoCadastro(nelson, sorteq);

            Assert.IsNull(solicitacaoCadastro.Fluxo);

            var cadastro = new Fluxo(new FluxoCriacao(), samarco, pessoaJuridica);
            var a = new Etapa("A");
            cadastro.AdicionarPassos(a, new Passo("A.1"), new Passo("A.2"));
            cadastro.AdicionarPassos(new Etapa("B"), new Passo("B.1"));
            cadastro.AdicionarPassos(new Etapa("C"), new Passo("C.1"), new Passo("C.2"), new Passo("C.3"));

            solicitacaoCadastro.SetFluxo(cadastro);

            Assert.AreEqual(solicitacaoCadastro.EtapaAtual, a);
            cadastro.AprovarPasso(new Passo("A.2"));

            //var cadastroDeFornecedor = new Fluxo(cadastroFornecedor, _samarco, _pessoaJuridica);
            //var cadastroFornecedor = new TipoFluxo("Cadastro de Fornecedor");
            //solicitacaoCadastro.Tipo.SetFluxo(cadastroDeFornecedor);
            //cadastroDeFornecedor.AdicionarEtapas(new Etapa("Solicitacao"), new Etapa("MDA"), new Etapa("Conclusão"));
            //Assert.AreEqual(cadastroDeFornecedor.EtapaAtual.Nome, "Solicitacao");
            //Assert.AreEqual(solicitacaoCadastro.Tipo.Fluxo.EtapaAtual.Nome, "Solicitacao");
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Entities.Tipos;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class SolicitacaoTests
    {
        [TestMethod]
        public void CriarSolicitacao()
        {
            var nelson = new Usuario("nelson.neto");
            Empresa sorteq = new Fornecedor("Sorteq", "12345678900", new TipoEmpresa("Fornecedor"));
            Solicitacao criacaoFornecedor = new TipoSolicitacaoCadastro(nelson, sorteq);
            Assert.AreEqual(criacaoFornecedor.Criador.Contratante, nelson.Contratante);
            Assert.AreEqual(criacaoFornecedor.Solicitante, nelson.Contratante);
            Assert.AreEqual(criacaoFornecedor.Solicitado, sorteq);
        }

        [TestMethod]
        public void CriarSolicitacaoCriacaoFornecedor()
        {
            var nelson = new Usuario("nelson.neto");
            Empresa sorteq = new Fornecedor("Sorteq", "12345678900", new TipoEmpresa("Fornecedor"));
            Solicitacao criacaoFornecedor = new TipoSolicitacaoCadastro(nelson, sorteq);
            Assert.AreEqual(criacaoFornecedor.Criador, nelson);
            Assert.AreEqual(criacaoFornecedor.Solicitante, nelson.Contratante);
        }
    }
}
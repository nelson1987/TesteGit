using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class DocumentoTests
    {
        [TestMethod]
        public void CriarDocumento()
        {
            var carteiraDeHabilitacao = new Documento("CNH - Carteira Nacional de Habilitação");
            Assert.AreEqual(carteiraDeHabilitacao.Arquivos.Count, 0);
        }

        [TestMethod]
        public void AdicionarDocumentoParaUmaEmpresa()
        {
            var carteiraDeHabilitacao = new Documento("CNH - Carteira Nacional de Habilitação");
            var sorteq = new Empresa("Sorteq", "12345678900", new TipoEmpresa("Fornecedor"));
            sorteq.AdicionarDocumento(carteiraDeHabilitacao);
            Assert.AreEqual(sorteq.Anexos.Count, 1);
            Assert.AreEqual(carteiraDeHabilitacao.Arquivos.Count, 0);
        }
    }
}
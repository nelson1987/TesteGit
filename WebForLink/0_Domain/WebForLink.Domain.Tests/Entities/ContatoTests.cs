using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class ContatoTests
    {
        [TestMethod]
        public void CriarContato()
        {
            var pauloDaSorteq = new Contato("Paulo", "nelson.neto@hotmail.com", "21 3456-7890", "21 93456-7890");
            Assert.AreEqual(pauloDaSorteq.Nome, "Paulo");
        }

        [TestMethod]
        public void AdicionarContatoAUmaEmpresa()
        {
            var pauloDaSorteq = new Contato("Paulo", "nelson.neto@hotmail.com", "21 3456-7890", "21 93456-7890");
            var sorteq = new Empresa("Sorteq", "12345678900", new TipoEmpresa("Fornecedor"));
            sorteq.AdicionarContato(pauloDaSorteq);
        }
    }
}
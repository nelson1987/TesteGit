using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class AplicacaoTests
    {
        [TestMethod]
        public void CriarAplicacao()
        {
            var webforlink = new Aplicacao("WebForLink");
            Assert.AreEqual(webforlink.Nome, "WebForLink");
            Assert.AreEqual(webforlink.Usuarios.Count, 0);
        }

        [TestMethod]
        public void IncluirUsuarioNaAplicacao()
        {
            var webforlink = new Aplicacao("WebForLink");
            var nelsonNeto = new Usuario("nelson.neto");
            webforlink.AdicionarUsuario(nelsonNeto);
            Assert.AreEqual(webforlink.Usuarios.Count, 1);
        }
    }
}
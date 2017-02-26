using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class PerfilTests
    {
        [TestMethod]
        public void CriarPerfil()
        {
            var webforLink = new Aplicacao("WebForLink", "Cadastro De Fornecedores");
            var administrador = new Perfil("Administrador");
            webforLink.AdicionarPerfil(administrador);
            Assert.AreEqual(webforLink.Perfis.Count, 1);
            Assert.AreEqual(webforLink.Perfis[0].Nome, "Administrador");
        }
    }
}
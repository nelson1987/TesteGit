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
            var webforlink = new Aplicacao("WebForLink", "Cadastro de Fornecedores");
            Assert.AreEqual(webforlink.Nome, "WebForLink");
            Assert.AreEqual(webforlink.Usuarios.Count, 0);
        }

        [TestMethod]
        public void IncluirUsuarioNaAplicacao()
        {
            var webforlink = new Aplicacao("WebForLink", "Cadastro de Fornecedores");
            var nelsonNeto = new Usuario("nelson.neto");
            webforlink.AdicionarUsuario(nelsonNeto);
            Assert.AreEqual(webforlink.Usuarios.Count, 1);
        }

        [TestMethod]
        public void CopiarUsuarioDeUmaAplicacaoParaOutra()
        {
            var nelsonNeto = new Usuario("nelson.neto");

            var webforlink = new Aplicacao("WebForLink", "Cadastro de Fornecedores");
            Assert.AreEqual(webforlink.Usuarios.Count, 0);
            webforlink.AdicionarUsuario(nelsonNeto);

            var webformat = new Aplicacao("WebForMat", "Cadastro de Materiais");
            Assert.AreEqual(webformat.Usuarios.Count, 0);
            webformat.AdicionarUsuario(nelsonNeto);

            Assert.AreEqual(webforlink.Usuarios.Count, 1);
            Assert.AreEqual(webformat.Usuarios.Count, 1);

            Assert.AreEqual(webforlink.Usuarios[0].Login, "nelson.neto");
            Assert.AreEqual(webformat.Usuarios[0].Login, "nelson.neto");
        }
    }
}
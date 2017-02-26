using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Entities.Tipos;

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
            var nelsonNeto = new Usuario("nelson.neto", webforlink, new Contratante("Samarco", new ClienteContratante()));
            webforlink.AdicionarUsuario(nelsonNeto);
            Assert.AreEqual(webforlink.Usuarios.Count, 1);
        }

        [TestMethod]
        public void CopiarUsuarioDeUmaAplicacaoParaOutra()
        {
            var webforlink = new Aplicacao("WebForLink", "Cadastro de Fornecedores");
            var nelsonNeto = new Usuario("nelson.neto", webforlink, new Contratante("Samarco", new ClienteContratante()));

            Assert.AreEqual(webforlink.Usuarios.Count, 0);

            var webformat = new Aplicacao("WebForMat", "Cadastro de Materiais");
            Assert.AreEqual(webformat.Usuarios.Count, 0);
            webforlink.AdicionarUsuario(nelsonNeto);
            webformat.AdicionarUsuario(nelsonNeto);

            Assert.AreEqual(webforlink.Usuarios.Count, 1);
            Assert.AreEqual(webformat.Usuarios.Count, 1);

            Assert.AreEqual(webforlink.Usuarios[0].Login, "nelson.neto");
            Assert.AreEqual(webformat.Usuarios[0].Login, "nelson.neto");
        }
    }
}
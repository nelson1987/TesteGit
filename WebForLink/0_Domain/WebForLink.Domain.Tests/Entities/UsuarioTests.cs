using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Entities.Tipos;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class UsuarioTests
    {
        private Usuario _nelson;
        private Contratante _samarco;
        private Aplicacao _webForLink;

        [TestInitialize]
        public void SetUp()
        {
            _webForLink = new Aplicacao("WebForLink", "Cadastro de Fornecedores");
            _samarco = new Contratante("Samarco", new ClienteContratante());
            _nelson = new Usuario("nelson.neto", _webForLink, _samarco);
        }

        [TestMethod]
        public void CriarUsuario()
        {
            Assert.AreEqual(_nelson.Login, "nelson.neto");
        }

        [TestMethod]
        public void IncluirUsuarioEmUmContratante()
        {
            var nelson = new Usuario("nelson.neto", new Aplicacao("WebForLink", ""),
                new Contratante("", new ClienteContratante()));
            var samarco = new Contratante("Samarco", new ClienteContratante());
            nelson.SetContratante(samarco);
            Assert.AreEqual(nelson.Contratante.RazaoSocial, "Samarco");
        }

        [TestMethod]
        public void IncluirUsuarioEmUmContratanteEmDuasAplicacoesDiferentes()
        {
            _webForLink.AdicionarUsuario(_nelson);
            _nelson.SetContratante(_samarco);
            Assert.AreEqual(_nelson.Contratante.RazaoSocial, "Samarco");
            Assert.AreEqual(_webForLink.Usuarios.Select(x => x.Contratante).FirstOrDefault(), _samarco);
        }

        [TestMethod]
        public void VerificarPerfilDeUsuario()
        {
            var administrador = new Perfil("Administrador");
            _webForLink.AdicionarPerfil(administrador);
            _nelson.AdicionarPerfil(administrador);
            Assert.AreEqual(_nelson.Perfis.Count, 1);
            Assert.AreEqual(_nelson.Perfis[0].Nome, "Administrador");
        }
    }
}
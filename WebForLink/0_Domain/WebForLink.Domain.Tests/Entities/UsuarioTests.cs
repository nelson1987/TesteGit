using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class UsuarioTests
    {
        private Aplicacao _webForLink;
        private Usuario _nelson;
        private Contratante _samarco;
        [TestInitialize]
        public void SetUp()
        {
            _webForLink = new Aplicacao("WebForLink", "Cadastro de Fornecedores");
            _samarco = new Contratante("Samarco");
            _nelson = new Usuario("nelson.neto",_webForLink, _samarco);
        }

        [TestMethod]
        public void CriarUsuario()
        {
            Assert.AreEqual(_nelson.Login, "nelson.neto");
        }

        [TestMethod]
        public void IncluirUsuarioEmUmContratante()
        {
            var nelson = new Usuario("nelson.neto");
            var samarco = new Contratante("Samarco");
            nelson.ContratadoPor(samarco);
            Assert.AreEqual(nelson.Contratante.RazaoSocial, "Samarco");
        }

        [TestMethod]
        public void IncluirUsuarioEmUmContratanteEmDuasAplicacoesDiferentes()
        {
            _webForLink.AdicionarUsuario(_nelson);
            _nelson.ContratadoPor(_samarco);
            Assert.AreEqual(_nelson.Contratante.RazaoSocial, "Samarco");
            Assert.AreEqual(_webForLink.Usuarios.Select(x => x.Contratante).FirstOrDefault(), _samarco);
        }

        [TestMethod]
        public void VerificarPerfilDeUsuario()
        {
            Perfil administrador = new Perfil("Administrador");
            _webForLink.AdicionarPerfil(administrador);
            _nelson.AdicionarPerfil(administrador);
            Assert.AreEqual(_nelson.Perfis.Count, 1);
            Assert.AreEqual(_nelson.Perfis[0].Nome, "Administrador");
        }
    }
}
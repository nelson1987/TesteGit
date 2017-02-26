using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class UsuarioTests
    {
        [TestMethod]
        public void CriarUsuario()
        {
            var aplicacao = new Aplicacao("WebForLink", "Cadastro de Fornecedores");
            var samarco = new Contratante("Samarco");
            var nelson = new Usuario("nelson.neto", aplicacao, samarco);
            Assert.AreEqual(nelson.Login, "nelson.neto");
            //Assert.AreEqual(nelson.VisualizarFornecedores.Count, 0);
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
            var webforlink = new Aplicacao("WebForLink", "Cadastro de Fornecedores");
            var nelson = new Usuario("nelson.neto");
            webforlink.AdicionarUsuario(nelson);
            var samarco = new Contratante("Samarco");
            nelson.ContratadoPor(samarco);
            Assert.AreEqual(nelson.Contratante.RazaoSocial, "Samarco");
            Assert.AreEqual(webforlink.Usuarios.Select(x => x.Contratante).FirstOrDefault(), samarco);
        }
    }
}
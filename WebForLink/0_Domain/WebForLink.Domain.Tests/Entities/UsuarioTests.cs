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
            var nelson = new Usuario("nelson.neto");
            Assert.AreEqual(nelson.Login, "nelson.neto");
            Assert.AreEqual(nelson.VisualizarFornecedores.Count, 0);
        }

        [TestMethod]
        public void IncluirUsuarioEmUmContratante()
        {
            var nelson = new Usuario("nelson.neto");
            var samarco = new Contratante("Samarco");
            nelson.ContratadoPor(samarco);
            Assert.AreEqual(nelson.Contratante.RazaoSocial, "Samarco");
        }
    }
}
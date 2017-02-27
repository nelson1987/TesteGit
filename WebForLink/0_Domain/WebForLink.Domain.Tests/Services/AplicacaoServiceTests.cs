using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Entities.Tipos;

namespace WebForLink.Domain.Tests.Services
{
    [TestClass]
    public class AplicacaoServiceTests
    {
        private List<Aplicacao> _aplicacoes;
        private Contratante _samarco;
        private Contratante _skf;
        private Contratante _sorteq;

        [TestInitialize]
        public void SetUp()
        {
            _aplicacoes = new List<Aplicacao>
            {
                new Aplicacao("WebForLink", "Cadastro De Fornecedores"),
                new Aplicacao("WebForMat", "Cadastro De Materiais"),
                new Aplicacao("WebForFac", "Cadastro De Fabricantes")
            };
            _sorteq = new ClienteAncora("Sorteq");
            _samarco = new FornecedorIndividual("Samarco", new EmpressaPessoaJuridica());
            _skf = new FabricanteAncora("Skf");
        }

        [TestMethod]
        public void ValidarAplicacao()
        {
            var webForFac = _aplicacoes.FirstOrDefault(x => x.Nome == "WebForFac");
            webForFac.AdicionarUsuario("nelson.neto", _sorteq);
            Assert.AreEqual(webForFac.Usuarios[0].Contratante.Solicitacoes.Count, 0);
        }

        [TestMethod]
        public void CriarPerfisAplicacao()
        {
            var webForFac = _aplicacoes.FirstOrDefault(x => x.Nome == "WebForFac");
            webForFac.AdicionarPerfil(new Perfil("Administrador"));
            webForFac.AdicionarPerfil(new Perfil("Visitante"));
            webForFac.AdicionarPerfil(new Perfil("Gerente"));
            webForFac.AdicionarPerfil(new Perfil("Visualizador"));
            //Assert.AreEqual(webForFac.Usuarios[0].Contratante.Solicitacoes.Count, 0);
        }

        [TestMethod]
        public void CriarUsuariosParaAplicacaoEmDiferentesContratantes()
        {
            var webForFac = _aplicacoes.FirstOrDefault(x => x.Nome == "WebForFac");
            Assert.AreEqual(webForFac.Usuarios.Count, 0);
            webForFac.AdicionarUsuario("nelson.neto", _sorteq);
            Assert.AreEqual(webForFac.Usuarios.Count, 1);
            Assert.AreEqual(webForFac.Usuarios[0].Login, "nelson.neto");

            webForFac.AdicionarUsuario("nelson.neto", _samarco);
            Assert.AreEqual(webForFac.Usuarios.Count, 1);
            Assert.AreEqual(webForFac.Usuarios[0].Login, "nelson.neto");

            webForFac.AdicionarUsuario("nelson.neto", _skf);
            Assert.AreEqual(webForFac.Usuarios.Count, 1);
            Assert.AreEqual(webForFac.Usuarios[0].Login, "nelson.neto");
        }

        [TestMethod]
        public void CriarUsuarioParaAplicacao()
        {
            var webForFac = _aplicacoes.FirstOrDefault(x => x.Nome == "WebForFac");
            Assert.AreEqual(webForFac.Usuarios.Count, 0);
            webForFac.AdicionarUsuario("nelson.neto", _sorteq);
            Assert.AreEqual(webForFac.Usuarios.Count, 1);
            Assert.AreEqual(webForFac.Usuarios[0].Login, "nelson.neto");
        }

        [TestMethod]
        public void InativarAplicacao()
        {
            Assert.AreEqual(_aplicacoes.FirstOrDefault(x => x.Nome == "WebForFac").Nome, _aplicacoes[2].Nome);
            var webForFac = _aplicacoes.FirstOrDefault(x => x.Nome == "WebForFac");
            Assert.IsTrue(webForFac.Ativo);
            webForFac.SetAtivo(false);
            Assert.IsFalse(webForFac.Ativo);
        }
    }
}
using System;
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
        private Contratante _sorteq;
        private Contratante _samarco;
        private Contratante _skf;

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
            _samarco = new FornecedorIndividual("Samarco");
            _skf = new FabricanteAncora("Skf");
        }
        [TestMethod]
        public void ValidarAplicacao()
        {
            var webForFac = _aplicacoes.FirstOrDefault(x => x.Nome == "WebForFac");
            Assert.AreEqual(webForFac.Usuarios.Count, 0);
            webForFac.AdicionarUsuario("nelson.neto", _sorteq);
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

﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Entities.Tipos;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class ContratanteTests
    {
        private Contratante Samarco;

        [TestInitialize]
        public void SetUp()
        {
            Samarco = new ClienteAncora("Samarco");
        }

        [TestMethod]
        public void CriarContratante()
        {
            Assert.AreEqual(Samarco.RazaoSocial, "Samarco");
            Assert.AreEqual(Samarco.EmpresasCadastradas.Count, 0);
        }

        [TestMethod]
        public void AdicionarEmpresaAUmContratante()
        {
            Empresa sorteq = new Fornecedor("Sorteq", "12345678900", new EmpressaPessoaJuridica());
            // new TipoEmpresa("Fornecedor"));
            Assert.AreEqual(Samarco.EmpresasCadastradas.Count, 0);
            Samarco.AdicionarEmpresa(sorteq);
            Assert.AreEqual(Samarco.EmpresasCadastradas.Count, 1);
        }

        [TestMethod]
        public void ValidarEmpresaContratanteEFornecedorIndividual()
        {
            Samarco = new ClienteAncora("Samarco");
            var samarcoDados = new Cliente("Samarco", "12345678900", new EmpressaPessoaJuridica());
            //new TipoEmpresa("Fornecedor"));
            Samarco.SetDadosGerais(samarcoDados);
            Assert.AreEqual(Samarco.DadosGerais.RazaoSocial, samarcoDados.RazaoSocial);
            //Assert.AreEqual(Samarco, "Fornecedor Individual");
        }

        [TestMethod]
        public void ValidarEmpresaContratanteEClienteAncora()
        {
            var samarco = new ClienteAncora("Samarco");
            var samarcoDados = new Cliente("Samarco", "12345678900", new EmpressaPessoaJuridica());
            //new TipoEmpresa("Fornecedor"));
            samarco.SetDadosGerais(samarcoDados);
            Assert.AreEqual(samarco.DadosGerais.RazaoSocial, samarcoDados.RazaoSocial);
        }
    }
}
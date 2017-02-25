﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class EmpresaTests
    {
        private Contratante contratante;
        private Empresa empresa;
        private TipoEmpresa pessoaJuridica;
        private StatusEmpresa statusEmpresa;

        [TestInitialize]
        public void SetUp()
        {
            empresa = new Empresa("Nova Empresa", "1234567890001");
            pessoaJuridica = new TipoEmpresa("Pessoa Jurídica");
            contratante = new Contratante("Zamarco");
            statusEmpresa = new StatusEmpresa("Ativo");
        }

        [TestMethod]
        public void CriarEmpresa()
        {
            empresa.SetTipoEmpresa(pessoaJuridica);
            empresa.Contratantes.Add(contratante);
            empresa.SetStatusEmpresa(statusEmpresa);
        }
    }
}
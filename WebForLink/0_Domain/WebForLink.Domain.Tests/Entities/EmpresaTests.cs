using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Entities.Status;
using WebForLink.Domain.Entities.Tipos;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class EmpresaTests
    {
        private Contratante _contratante;
        private Empresa _empresa;
        private TipoEmpresa _pessoaJuridica;
        private StatusEmpresa _statusEmpresa;

        [TestInitialize]
        public void SetUp()
        {
            _pessoaJuridica = new EmpressaPessoaJuridica();//new TipoEmpresa("Pessoa Jurídica");
            _empresa = new Fornecedor("Nova Empresa", "1234567890001", _pessoaJuridica);
            _contratante = new Contratante("Zamarco", new ClienteContratante());
            _statusEmpresa = new StatusEmpresa("Ativo");
        }

        [TestMethod]
        public void CriarEmpresa()
        {
            _empresa.SetTipoEmpresa(_pessoaJuridica);
            _empresa.Contratantes.Add(_contratante);
            _empresa.SetStatusEmpresa(_statusEmpresa);
        }
    }
}
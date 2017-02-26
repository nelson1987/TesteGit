using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Entities.Tipos;

namespace WebForLink.Domain.Tests.Entities
{
    [TestClass]
    public class CriarSolicitacaoTests
    {
        [TestMethod]
        public void ExecutarASolicitacaoDeCadastroDeFornecedoresCompleta()
        {
            TipoContratante clienteAncora = new ClienteContratante();
            TipoEmpresa pessoaJuridica = new EmpressaPessoaJuridica();
            Aplicacao webForLink = new Aplicacao("WebForLink","Cadastro De Fornecedores");
            Usuario nelson = new Usuario("nelson");
            Contratante samarco = new Contratante("Samarco",clienteAncora);
            Empresa sorteq = new Fornecedor("Sorteq", "12345678900", pessoaJuridica);
            Solicitacao solicitacaoCadastro = new SolicitacaoCadastro(nelson, sorteq);
            Assert.AreEqual(webForLink.TotalSolicitacoes, 1);
        }
    }
}

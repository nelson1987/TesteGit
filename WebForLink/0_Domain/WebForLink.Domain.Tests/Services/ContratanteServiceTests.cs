using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Services;

namespace WebForLink.Domain.Tests.Services
{
    [TestClass]
    public class ContratanteServiceTests
    {
        [TestMethod]
        public void IncluirEmpresaRecemAderidaAoWebForLink()
        {
            var webforlink = new Aplicacao("WebForLink");

            var nelson = new Usuario("nelson.neto");
            var samarco = new Contratante("Samarco");
            var statusEmpresa = new StatusEmpresa("Ativo");
            nelson.ContratadoPor(samarco);
            var fornecedores = nelson.VisualizarFornecedores;
            var fornecedoresAtivos = nelson.VisualizarFornecedoresCadastrados;

            //Empresa fornecedor = nelson.Contratante

            var servico = new IncluirContratanteService(nelson, samarco);
        }
    }
}
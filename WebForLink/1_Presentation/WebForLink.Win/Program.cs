using WebForLink.Domain.Services;
using WebForLink.Win.Contexto;

namespace WebForLink.Win
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var servico = new ContratanteService();
            var contaBradesco = new Domain.Entities.Banco("Itau", "Itaú Bradesco");
            servico.IncluirBanco(contaBradesco);
            using (var contexto = new WebForLinkContext())
            {
                contexto.Contratante.Add(servico._contratante);
                contexto.SaveChanges();
            }
        }
    }
}
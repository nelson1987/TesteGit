using System.Collections.Generic;
using System.Linq;
using WebForLink.Domain.Entities.Tipos;

namespace WebForLink.Domain.Entities
{
    public class Fluxo
    {
        private Fluxo()
        {
            Etapas = new List<Etapa>();
        }

        public Fluxo(TipoFluxo tipo, Contratante contratante, TipoEmpresa tipoEmpresa)
            : this()
        {
            Nome = tipo.Nome;
            TipoFluxo = tipo;
            Contratante = contratante;
            TipoEmpresa = tipoEmpresa;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public TipoFluxo TipoFluxo { get; private set; }
        public TipoEmpresa TipoEmpresa { get; private set; }
        public Contratante Contratante { get; private set; }
        public List<Etapa> Etapas { get; private set; }

        public Etapa EtapaAtual
        {
            get { return Etapas.FirstOrDefault(x => !x.Aprovado); }
        }

        public void AdicionarEtapas(params Etapa[] etapas)
        {
            Etapas.AddRange(etapas);
        }

        public void AdicionarPassos(Etapa etapa, params Passo[] passo1)
        {
            etapa.AdicionarPassos(passo1);
            Etapas.Add(etapa);
        }

        public void AprovarPasso(Passo passo)
        {
            var passoAprovado = EtapaAtual.Passos.FirstOrDefault(y => y == passo);
            if (passoAprovado != null)
                passoAprovado.SetAprovado(true);
        }
    }
}
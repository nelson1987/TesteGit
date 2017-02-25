using System.Collections.Generic;
using System.Linq;

namespace WebForLink.Domain.Entities
{
    public class Fluxo
    {
        protected Fluxo()
        {
            Etapas = new List<Etapa>();
        }

        public Fluxo(string nome) : this()
        {
            Nome = nome;
        }

        public Fluxo(TipoFluxo tipo, Contratante contratante, TipoEmpresa tipoEmpresa):this()
        {
            TipoFluxo = tipo;
            Contratante = contratante;
            TipoEmpresa = tipoEmpresa;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public TipoFluxo TipoFluxo { get; private set; }
        public TipoEmpresa TipoEmpresa { get; private set; }
        public Contratante Contratante { get; private set; }
        public List<Etapa> Etapas { get; set; }
        public Etapa EtapaAtual {
            get { return Etapas.FirstOrDefault(x => !x.Aprovado); }
        }

        public void AdicionarEtapas(params Etapa[] etapas)
        {
            Etapas.AddRange(etapas);
        }
    }
}
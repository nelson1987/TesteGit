namespace WebForLink.Domain.Entities
{
    public class Fluxo
    {
        protected Fluxo()
        {
        }

        public Fluxo(string nome) : this()
        {
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public TipoFluxo TipoFluxo { get; private set; }
        public Contratante Contratante { get; private set; }
    }
}
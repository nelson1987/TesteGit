namespace WebForLink.Domain.Entities
{
    public class TipoFluxo
    {
        protected TipoFluxo()
        {
        }

        public TipoFluxo(string nome)
            : this()
        {
            Nome = nome;
        }

        public TipoFluxo(int id, string nome)
            : this(nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
    }
}
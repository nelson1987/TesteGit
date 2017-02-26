namespace WebForLink.Domain.Entities
{
    public class Passo
    {
        protected Passo()
        {
        }

        public Passo(string descricao)
            : this()
        {
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public bool Aprovado { get; private set; }

        public void SetAprovado(bool aprovado)
        {
            Aprovado = aprovado;
        }
    }
}
namespace WebForLink.Domain.Entities
{
    public class Banco
    {
        private Banco()
        {
        }

        public Banco(string codigo, string nome) : this()
        {
            Codigo = codigo;
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Codigo { get; private set; }
        public string Nome { get; private set; }
    }
}
namespace WebForLink.Domain.ValueObject
{
    public class Pais
    {
        private Pais()
        {
        }

        public Pais(string codigo, string descricao)
            : this()
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Codigo { get; private set; }
        public string Descricao { get; private set; }
    }

    public class UnidadeDaFederacao
    {
        private UnidadeDaFederacao()
        {
        }

        public UnidadeDaFederacao(Pais pais, string codigo, string descricao)
            : this()
        {
            Pais = pais;
            Codigo = codigo;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public Pais Pais { get; private set; }
        public string Codigo { get; private set; }
        public string Descricao { get; private set; }
    }

    public class Municipio
    {
        private Municipio()
        {
        }

        public Municipio(UnidadeDaFederacao uf, string codigo, string descricao)
            : this()
        {
            Uf = uf;
            Codigo = codigo;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public UnidadeDaFederacao Uf { get; private set; }
        public string Codigo { get; private set; }
        public string Descricao { get; private set; }
    }
}
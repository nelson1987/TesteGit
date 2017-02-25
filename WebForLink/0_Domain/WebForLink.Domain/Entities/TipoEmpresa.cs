using System.Collections.Generic;

namespace WebForLink.Domain.Entities
{
    public class TipoEmpresa
    {
        protected TipoEmpresa()
        {
        }

        public TipoEmpresa(string nome)
            : this()
        {
            Nome = nome;
        }

        public TipoEmpresa(int id, string nome)
            : this(nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public List<Contratante> Contratantes { get; private set; }
    }
}
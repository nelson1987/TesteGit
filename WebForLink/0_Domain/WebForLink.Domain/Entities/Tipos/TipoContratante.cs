using System.Collections.Generic;

namespace WebForLink.Domain.Entities.Tipos
{
    public class TipoContratante
    {
        protected TipoContratante()
        {
        }

        public TipoContratante(string nome)
            : this()
        {
            Nome = nome;
        }

        public TipoContratante(int id, string nome)
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
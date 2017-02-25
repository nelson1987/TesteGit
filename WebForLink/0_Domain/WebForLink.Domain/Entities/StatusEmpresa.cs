using System.Collections.Generic;

namespace WebForLink.Domain.Entities
{
    public class StatusEmpresa
    {
        protected StatusEmpresa()
        {
        }

        public StatusEmpresa(string nome)
        {
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public List<Empresa> Empresas { get; private set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForLink.Domain.Entities
{
    public class Perfil
    {
        protected Perfil()
        {
            
        }

        public Perfil(string nome) : this()
        {
            Nome = nome;
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public List<Usuario> Usuarios { get; private set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForLink.Domain.Entities
{
    public class Papel
    {
        private Papel()
        {

        }
        private Papel(string nome)
        {
            Nome = nome;
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public List<Usuario> Usuarios { get; private set; }
    }
}

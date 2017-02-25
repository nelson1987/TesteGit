using System.Collections.Generic;

namespace WebForLink.Domain.Entities
{
    public class Aplicacao
    {
        protected Aplicacao()
        {
            Usuarios = new List<Usuario>();
        }

        public Aplicacao(string nome)
        {
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public List<Usuario> Usuarios { get; private set; }

        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace WebForLink.Domain.Entities
{
    public class Aplicacao
    {
        private Aplicacao()
        {
            Usuarios = new List<Usuario>();
            Perfis = new List<Perfil>();
        }

        public Aplicacao(string nome, string descricao)
            : this()
        {
            Nome = nome;
            Descricao = descricao;
            Ativo = true;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public List<Usuario> Usuarios { get; private set; }
        public List<Perfil> Perfis { get; private set; }

        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }
        public void AdicionarUsuario(string login,Contratante contratante)
        {
            Usuarios.Add(new Usuario(login, this, contratante));
        }

        public void AdicionarPerfil(Perfil perfil)
        {
            Perfis.Add(perfil);
        }

        public bool TemEssePerfil(Perfil perfil)
        {
            return Perfis.Any(x => x == perfil);
        }

        public void SetAtivo(bool ativo)
        {
            Ativo = ativo;
        }
    }
}
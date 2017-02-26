using System.Collections.Generic;

namespace WebForLink.Domain.Entities
{
    public class Usuario
    {
        private Usuario()
        {
            Perfis = new List<Perfil>();
        }

        public Usuario(string login, Aplicacao aplicacao, Contratante contratante)
            : this()
        {
            Login = login;
            Aplicacao = aplicacao;
            Contratante = contratante;
        }

        public int Id { get; private set; }
        public string Login { get; private set; }
        public Contratante Contratante { get; private set; }
        public Aplicacao Aplicacao { get; private set; }
        public List<Perfil> Perfis { get; private set; }
        public List<Papel> Papeis { get; private set; }

        public void SetContratante(Contratante contratante)
        {
            Contratante = contratante;
        }

        public void AdicionarPerfil(Perfil administrador)
        {
            if (Aplicacao.TemEssePerfil(administrador))
                Perfis.Add(administrador);
        }
    }
}
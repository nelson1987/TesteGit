using System.Collections.Generic;
using WebForLink.Domain.Entities.Tipos;

namespace WebForLink.Domain.Entities
{
    public abstract class Contratante
    {
        private Contratante()
        {
            EmpresasCadastradas = new List<Empresa>();
            Solicitacoes = new List<Solicitacao>();
        }

        protected Contratante(string razaoSocial)
            : this()
        {
            RazaoSocial = razaoSocial;
        }

        public int Id { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Documento { get; private set; }
        public TipoEmpresa TipoEmpresa { get; private set; }
        public Cliente DadosGerais { get; private set; }
        public List<ConfiguracaoSistema> ConfiguracaoSistemas { get; private set; }
        //public Usuario Criador { get; private set; }
        public List<Empresa> EmpresasCadastradas { get; private set; }
        public List<Usuario> Usuarios { get; private set; }
        public List<Solicitacao> Solicitacoes { get; private set; }
        //public void SetCriador(Usuario usuario)
        //{
        //    Criador = usuario;
        //}

        public void AdicionarEmpresa(Empresa sorteq)
        {
            EmpresasCadastradas.Add(sorteq);
        }

        public void SetDadosGerais(Cliente empresa)
        {
            DadosGerais = empresa;
        }
    }
}
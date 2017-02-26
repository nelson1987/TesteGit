using System.Collections.Generic;

namespace WebForLink.Domain.Entities
{
    public class Contratante
    {
        protected Contratante()
        {
            EmpresasCadastradas = new List<Empresa>();
        }

        public Contratante(string razaoSocial)
            : this()
        {
            RazaoSocial = razaoSocial;
        }

        public Contratante(string razaoSocial, TipoContratante tipo)
            : this(razaoSocial)
        {
            TipoContratante = tipo;
        }

        public int Id { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Documento { get; private set; }
        public TipoContratante TipoContratante { get; private set; }
        public TipoEmpresa TipoEmpresa { get; private set; }
        public List<ConfiguracaoSistema> ConfiguracaoSistemas { get; private set; }
        //public Usuario Criador { get; private set; }
        public List<Empresa> EmpresasCadastradas { get; private set; }
        public List<Usuario> Usuarios { get; private set; }
        public Cliente DadosGerais { get; private set; }

        //public void SetCriador(Usuario usuario)
        //{
        //    Criador = usuario;
        //}

        public void AdicionarEmpresa(Empresa sorteq)
        {
            EmpresasCadastradas.Add(sorteq);
        }

        public void SetTipo(TipoContratante tipoContratante)
        {
            TipoContratante = tipoContratante;
        }

        public void SetDadosGerais(Cliente empresa)
        {
            DadosGerais = empresa;
        }
    }
}
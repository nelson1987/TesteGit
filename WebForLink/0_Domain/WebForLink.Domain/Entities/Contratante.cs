using System.Collections.Generic;
using WebForLink.Domain.Entities.Categorias;
using WebForLink.Domain.Entities.Status;
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

        protected Contratante(string razaoSocial, TipoEmpresa tipoEmpresa)
            : this()
        {
            RazaoSocial = razaoSocial;
            TipoEmpresa = tipoEmpresa;
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
        public List<PreCadastro> PreCadastros { get; private set; }
        public List<StatusPreCadastro> StatusPreCadastros { get; private set; }
        public List<StatusEmpresa> StatusEmpresas { get; private set; }

        public void AdicionarEmpresa(Empresa sorteq)
        {
            EmpresasCadastradas.Add(sorteq);
        }

        public void SetDadosGerais(Cliente empresa)
        {
            DadosGerais = empresa;
        }

        public void AdicionarSolicitacao(Solicitacao solicitacao)
        {
            Solicitacoes.Add(solicitacao);
        }

        public void AdicionarPerfil(Perfil perfil)
        {
            Perfis.Add(perfil);
        }

        public List<Perfil> Perfis { get; private set; }
        public List<Papel> Papeis { get; private set; }

        internal void AdicionarPapel(Papel papel)
        {
            Papeis.Add(papel);
        }

        public List<Documento> Documentos { get; private set; }
        internal void IncluirDocumento(Documento documento)
        {
            Documentos.Add(documento);
        }

        internal void IncluirCliente(Cliente empresa)
        {
            EmpresasCadastradas.Add(empresa);
        }

        internal void IncluirFabricante(Fabricante empresa)
        {
            EmpresasCadastradas.Add(empresa);
        }

        public List<CategoriaEmpresa> CategoriasCadastradas { get; private set; }
        internal void IncluirCategoria(CategoriaEmpresa categoria)
        {
            CategoriasCadastradas.Add(categoria);
        }
        internal void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public List<Banco> Bancos { get; private set; }
        internal void IncluirBanco(Banco banco)
        {
            Bancos.Add(banco);
        }

        public List<Importacao> Importacoes { get; private set; }
        internal void IncluirImportacao(Importacao importacao)
        {
            throw new System.NotImplementedException();
        }
    }
}
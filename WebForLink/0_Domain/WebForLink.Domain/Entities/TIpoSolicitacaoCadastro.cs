namespace WebForLink.Domain.Entities
{
    public class TipoSolicitacaoCadastro : Solicitacao
    {
        public TipoSolicitacaoCadastro(Usuario nelson, Empresa sorteq)
            : base(nelson, sorteq)
        {
            SetTipo(new TipoSolicitacao("Cadastro de Empresa"));
        }
    }
}
namespace WebForLink.Domain.Entities.Tipos
{
    public class SolicitacaoCadastro : Solicitacao
    {
        public SolicitacaoCadastro(Usuario criador, Empresa solicitado)
            : base(criador, solicitado)
        {
        }
    }
}
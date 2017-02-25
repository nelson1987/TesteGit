namespace WebForLink.Domain.Entities
{
    public class TIpoSolicitacaoUnspsc
    {
        public int Id { get; private set; }
        public Solicitacao Solicitacao { get; private set; }
        public Material MaterialDeEmpresa { get; private set; }
    }
}
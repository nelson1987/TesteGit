namespace WebForLink.Domain.Entities
{
    public class TipoSolicitacao
    {
        protected TipoSolicitacao()
        {
        }

        public TipoSolicitacao(string descricao)
        {
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public Fluxo Fluxo { get; private set; }
    }
}
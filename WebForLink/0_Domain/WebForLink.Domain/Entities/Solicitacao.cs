namespace WebForLink.Domain.Entities
{
    public class Solicitacao
    {
        protected Solicitacao()
        {
        }

        public Solicitacao(Usuario criador, Empresa solicitado)
            : this()
        {
            Criador = criador;
            Solicitado = solicitado;
        }

        public int Id { get; private set; }
        public Empresa Solicitado { get; private set; }
        public TipoSolicitacao Tipo { get; private set; }
        public Usuario Criador { get; private set; }

        public Contratante Solicitante
        {
            get { return Criador.Contratante; }
        }

        public void SetTipo(TipoSolicitacao tipo)
        {
            Tipo = tipo;
        }
    }
}
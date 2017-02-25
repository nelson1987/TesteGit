namespace WebForLink.Domain.Entities
{
    public class Solicitacao
    {
        public int Id { get; private set; }
        public Empresa Empresa { get; private set; }
        public Fluxo Fluxo { get; private set; }
        public Contratante Contratante { get; private set; }
    }
}
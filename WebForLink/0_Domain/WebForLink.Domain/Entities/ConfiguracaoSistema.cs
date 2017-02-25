namespace WebForLink.Domain.Entities
{
    public class ConfiguracaoSistema
    {
        public int Id { get; private set; }
        public string CaminhoArquivo { get; private set; }
        public Contratante Contratante { get; private set; }
    }
}
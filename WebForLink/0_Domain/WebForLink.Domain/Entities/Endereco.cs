namespace WebForLink.Domain.Entities
{
    public class Endereco
    {
        public int Id { get; private set; }
        public string RUa { get; private set; }
        public Empresa Empresa { get; private set; }
    }
}
namespace WebForLink.Domain.ValueObject
{
    public class Email
    {
        public Email(string endereco)
        {
            Endereco = endereco;
        }

        public int Id { get; private set; }
        public string Endereco { get; private set; }
    }
}
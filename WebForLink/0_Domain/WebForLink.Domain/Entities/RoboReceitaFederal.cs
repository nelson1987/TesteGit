namespace WebForLink.Domain.Entities
{
    public class RoboReceitaFederal : Robo
    {
        public RoboReceitaFederal(string razaoSocial)
            : base(razaoSocial)
        {
        }

        public string NomeFantasia { get; private set; }
    }
}
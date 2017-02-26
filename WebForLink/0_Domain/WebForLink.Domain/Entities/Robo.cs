namespace WebForLink.Domain.Entities
{
    public abstract class Robo
    {
        private Robo()
        {
        }

        protected Robo(string razaoSocial)
            : this()
        {
            RazaoSocial = razaoSocial;
        }

        public int Id { get; private set; }
        public string RazaoSocial { get; set; }
    }
}
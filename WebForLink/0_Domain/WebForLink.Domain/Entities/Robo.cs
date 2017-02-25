namespace WebForLink.Domain.Entities
{
    public class Robo
    {
        public RoboReceitaFederal RoboReceitaFederal { get; private set; }
        public RoboCorreios RoboCorreios { get; private set; }
        public RoboSimplesNacional RoboSimplesNacional { get; set; }
        public RoboSintegra RoboSintegra { get; set; }
        public RoboSuframa RoboSuframa { get; set; }
    }
}
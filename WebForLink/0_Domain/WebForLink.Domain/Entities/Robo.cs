using System.Security.AccessControl;

namespace WebForLink.Domain.Entities
{
    public class Robo
    {
        protected Robo()
        {
            
        }
        public int Id { get; private set; }
        public RoboReceitaFederal RoboReceitaFederal { get; private set; }
        public RoboCorreios RoboCorreios { get; private set; }
        public RoboSimplesNacional RoboSimplesNacional { get; set; }
        public RoboSintegra RoboSintegra { get; set; }
        public RoboSuframa RoboSuframa { get; set; }
    }
}
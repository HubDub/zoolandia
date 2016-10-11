namespace Zoolandia.Habitats
{
   public class Grassland : Habitat, IGrasslandHabitat
    {
        public double sqFootage {get; set;}
        public bool lake {get; set;}

        private List<Employee> SavannahCrew = new List<Employee>();
    } 
}
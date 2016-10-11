namespace Zoolandia.Habitats
{
    public class Aquarium : Habitat, IAquariumHabitat
    {
        public double volume {get; set;}
        public string composition {get; set;}
        public bool treeBranches {get; set;}
    }
}
using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
    public class Habitat
    {
        public string name;

        public List<Animal> inhabitants = new List<Animal>();
        public string public_name {get; set;}
    }
}


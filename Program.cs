using System;
using Zoolandia.Animals;
using Zoolandia.Enclosures;
using Zoolandia.Habitats;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //creating instances of habitats
            Grassland savannah = new Grassland()
            {
                sqFootage = 15000,
                lake = true,
                name = "Savannah Habitat"
            };

            Aviary aviary = new Aviary()
            {
                volume = 10000,
                trees = true,
                name = "Aviary Habitat"
            };
            //this is another way of instantiating objects and assigning props
            Aquarium wetAquarium = new Aquarium();
            wetAquarium.volume = 100000;
            wetAquarium.composition = "water";
            wetAquarium.treeBranches = false;
            wetAquarium.name = "Whale Habitat";

            Aquarium dryAquarium = new Aquarium();
            dryAquarium.volume = 30;
            dryAquarium.composition = "air";
            dryAquarium.treeBranches = true;
            dryAquarium.name = "Small Critters Habitat";


            //creating instances of iquanas
            Iguana billy = new Iguana()
            {
                name = "Billy",
                food = "insects",
                species = new DisosaurusDorsalis()
            };
            
            //creating instances of horses
            Horse dan = new Horse()
            {
                name = "Dan",
                food = "hay",
                species = new EquusFerusCaballus()
            };

            //creating instances of birds
            Bird dolly = new Bird()
            {
                name = "Dolly",
                food = "berries",
                species = new CardinalisCardinalis()
            };

            //creating instances of whales
            Whale ellen = new Whale()
            {
                name = "Ellen",
                food = "krill",
                species = new BalaenopteraMusculus()
            };

            //creating instances of elephants
            Elephant bob = new Elephant()
            {
                name = "Bob",
                food = "grass",
                species = new ElephasMaximusIndicus()
            };

            //creating instances of Lions
            Lion leo = new Lion()
            {
                name = "Leo",
                food = "slow impala",
                species = new PantheraLeo()
            };

            //adding animals to habitats
            dryAquarium.inhabitants.Add(billy);
            savannah.inhabitants.Add(dan);
            aviary.inhabitants.Add(dolly);
            wetAquarium.inhabitants.Add(ellen);
            savannah.inhabitants.Add(bob);
            savannah.inhabitants.Add(leo);

            // foreach(Animal critter in dryAquarium.inhabitants)
            // {
            //     Console.WriteLine($"\nAnimals in the dry aquarium habitat:\n{critter.name}, - {critter.species.commonName}");
            // }
            // foreach(Animal critter in savannah.inhabitants)
            // {
            //     Console.WriteLine($"\nAnimals in the savannah habitat:\n{critter.name}, - {critter.species.commonName}");
            // }
            // foreach(Animal critter in aviary.inhabitants)
            // {
            //     Console.WriteLine($"\nAnimals in the aviary habitat:\n{critter.name}, - {critter.species.commonName}");
            // }
            // foreach(Animal critter in wetAquarium.inhabitants)
            // {
            //     Console.WriteLine($"\nAnimals in the wet aquarium habitat:\n{critter.name}, - {critter.species.commonName}");
            // }

            //the above will output each critter in each habitat, but it's not in the format called for. it's also repeating the same code over and over so isn't dry. in order to get it in that format, we'll need a list of habitats to loop through. to create that, I had to create a new class that is outside of the Habitats namespace
            //so instantiate new allHabitats, which is located in zoo.cs in Enclosures folder and add the habitats to the list that is a property on AllHabitats
            AllHabitats zoolandia = new AllHabitats();
            zoolandia.allHabitats.Add(savannah);
            zoolandia.allHabitats.Add(aviary);
            zoolandia.allHabitats.Add(wetAquarium);
            zoolandia.allHabitats.Add(dryAquarium);
            
            //output
            Console.WriteLine("Welcome to Zoolandia!");
            foreach(Habitat habitat in zoolandia.allHabitats)
            {
                Console.WriteLine($"\nAnimals in {habitat.name}:");
                foreach(Animal critter in habitat.inhabitants)
                {
                    Console.WriteLine($"{critter.name} - {critter.species.commonName}");
                }
            }
        }
    }
}

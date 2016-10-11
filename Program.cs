using System;
using Zoolandia.Animals;
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
                name = "Savannah"
            };

            Aviary aviary = new Aviary()
            {
                volume = 10000,
                trees = true,
                name = "Aviary"
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
            //both Iguana and animal have greet method so it chooses the greet located on Iguana and then if told to go to the base from there it will run the greet method on Animal
            Console.WriteLine(billy.greet());
            //here is located in the Iguana class, but we can access it here because this is after a new iguana is instantiated. so the object has the hero on it
            Console.WriteLine($"His hero is {billy.hero}");
            //this calls the action method located on the Animal class. it does not matter what string I have added here, just adding a string makes it overload and run a specific method that calls for a string to be passed.
            Console.WriteLine(billy.action("radish"));
            //this console write digs into the species and then genus properties
            Console.WriteLine($"You can learn more about {billy.species.commonName}s at {billy.species.url} and about {billy.species.genus.commonName}s in general at {billy.species.genus.url}");
            
            //creating instances of horses
            Horse dan = new Horse()
            {
                name = "Dan",
                food = "hay",
                species = new EquusFerusCaballus()
            };
            Console.WriteLine(dan.greet());
            Console.WriteLine($"His hero is {dan.hero}.");  
            Console.WriteLine(dan.action());     

            //creating instances of birds
            Bird dolly = new Bird()
            {
                name = "Dolly",
                food = "berries",
                species = new CardinalisCardinalis()
            };
            Console.WriteLine(dolly.greet());
            Console.WriteLine($"Her hero is {dolly.hero}.");
            Console.WriteLine(dolly.action("cricket"));

            //creating instances of whales
            Whale ellen = new Whale()
            {
                name = "Ellen",
                food = "krill",
                species = new BalaenopteraMusculus()
            };
            Console.WriteLine(ellen.greet());
            Console.WriteLine($"Her hero is {ellen.hero}.");
            Console.WriteLine(ellen.singing("sing", 8));

            //creating instances of elephants
            Elephant bob = new Elephant()
            {
                name = "Bob",
                food = "grass",
                species = new ElephasMaximusIndicus()
            };
            Console.WriteLine(bob.greet());
            Console.WriteLine($"His hero is {bob.hero}.");
            Console.WriteLine(bob.action());

            //creating instances of Lions
            Lion leo = new Lion()
            {
                name = "Leo",
                food = "slow impala",
                species = new PantheraLeo()
            };
            Console.WriteLine(leo.greet());
            Console.WriteLine($"His hero is {leo.hero}.");
            Console.WriteLine(leo.activity("run", "gazelle", true));

            //adding animals to habitats
            dryAquarium.inhabitants.Add(billy);
            savannah.inhabitants.Add(dan);
            aviary.inhabitants.Add(dolly);
            wetAquarium.inhabitants.Add(ellen);
            savannah.inhabitants.Add(bob);
            savannah.inhabitants.Add(leo);

            foreach(Animal critter in dryAquarium.inhabitants)
            {
                Console.WriteLine($"\nAnimals in the Dry Aquarium:\ncritter.name");
            }
        }
    }
}

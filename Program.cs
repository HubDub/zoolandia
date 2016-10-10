using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
    //creating instances of iquanas
            Iguana firstIguana = new Iguana()
            {
                name = "Billy",
                food = "insects",
                species = new DisosaurusDorsalis()
            };
            //both Iguana and animal have greet method so it chooses the greet located on Iguana and then if told to go to the base from there it will run the greet method on Animal
            Console.WriteLine(firstIguana.greet());
            //here is located in the Iguana class, but we can access it here because this is after a new iguana is instantiated. so the object has the hero on it
            Console.WriteLine($"His hero is {firstIguana.hero}");
            //this calls the action method located on the Animal class. it does not matter what string I have added here, just adding a string makes it overload and run a specific method that calls for a string to be passed.
            Console.WriteLine(firstIguana.action("radish"));
            //this console write digs into the species and then genus properties
            Console.WriteLine($"You can learn more about {firstIguana.species.commonName}s at {firstIguana.species.url} and about {firstIguana.species.genus.commonName}s in general at {firstIguana.species.genus.url}");
            
    //creating instances of horses
            Horse firstHorse = new Horse()
            {
                name = "Dan",
                food = "hay",
                species = new EquusFerusCaballus()
            };
            Console.WriteLine(firstHorse.greet());
            Console.WriteLine($"His hero is {firstHorse.hero}.");  
            Console.WriteLine(firstHorse.action());     

    //creating instances of birds
            Bird firstBird = new Bird()
            {
                name = "Dolly",
                food = "berries",
                species = new CardinalisCardinalis()
            };
            Console.WriteLine(firstBird.greet());
            Console.WriteLine($"Her hero is {firstBird.hero}.");
            Console.WriteLine(firstBird.action("cricket"));

    //creating instances of whales
            Whale firstWhale = new Whale()
            {
                name = "Ellen",
                food = "krill",
                species = new BalaenopteraMusculus()
            };
            Console.WriteLine(firstWhale.greet());
            Console.WriteLine($"Her hero is {firstWhale.hero}.");
            Console.WriteLine(firstWhale.singing("sing", 8));

    //creating instances of elephants
            Elephant firstElephant = new Elephant()
            {
                name = "Bob",
                food = "grass",
                species = new ElephasMaximusIndicus()
            };
            Console.WriteLine(firstElephant.greet());
            Console.WriteLine($"His hero is {firstElephant.hero}.");
            Console.WriteLine(firstElephant.action());

    //creating instances of Lions
            Lion firstCat = new Lion()
            {
                name = "Leo",
                food = "slow impala",
                species = new PantheraLeo()
            };
            Console.WriteLine(firstCat.greet());
            Console.WriteLine($"His hero is {firstCat.hero}.");
            Console.WriteLine(firstCat.activity("run", "gazelle", true));
        }
    }
}

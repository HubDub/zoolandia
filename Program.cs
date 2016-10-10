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
            Console.WriteLine(firstIguana.greet());
            Console.WriteLine($"His hero is {firstIguana.hero}");
            Console.WriteLine(firstIguana.action("radish"));
            
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

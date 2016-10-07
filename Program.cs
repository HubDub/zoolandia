using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
    //creating instances of iquanas
            DisosaurusDorsalis firstIguana = new DisosaurusDorsalis()
            {
                name = "Billy",
                eats = "insects",
            };
            Console.WriteLine(firstIguana.greet());
            Console.WriteLine($"His hero is {firstIguana.hero}");
            Console.WriteLine(firstIguana.sleeps("yes"));
            
    //creating instances of horses
            EquusFerusCaballus firstHorse = new EquusFerusCaballus()
            {
                name = "Dan",
                eats = "hay"
            };
            Console.WriteLine(firstHorse.greet());
            Console.WriteLine($"His hero is {firstHorse.hero}.");  
            Console.WriteLine(firstHorse.talking());     

    //creating instances of birds
            CardinalisCardinalis firstBird = new CardinalisCardinalis()
            {
                name = "Dolly",
                eats = "berries"
            };
            Console.WriteLine(firstBird.greet());
            Console.WriteLine($"Her hero is {firstBird.hero}.");
            Console.WriteLine(firstBird.talking("yes"));

    //creating instances of whales
            BalaenopteraMusculus firstWhale = new BalaenopteraMusculus()
            {
                name = "Ellen",
                eats = "krill"
            };
            Console.WriteLine(firstWhale.greet());
            Console.WriteLine($"Her hero is {firstWhale.hero}.");
            Console.WriteLine(firstWhale.singing("yes", 2));

    //creating instances of elephants
            ElephasMaximusIndicus firstElephant = new ElephasMaximusIndicus()
            {
                name = "Bob",
                eats = "grass"
            };
            Console.WriteLine(firstElephant.greet());
            Console.WriteLine($"His hero is {firstElephant.hero}.");
            Console.WriteLine(firstElephant.running("yes", 10));

    //creating instances of Lions
            PantheraLeo firstCat = new PantheraLeo()
            {
                name = "Leo",
                eats = "slow impala"
            };
            Console.WriteLine(firstCat.greet());
            Console.WriteLine($"His hero is {firstCat.hero}.");
            Console.WriteLine(firstCat.action("yes", "gazelle", true));
        }
    }
}

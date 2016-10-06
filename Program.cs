using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal firstAnimal = null;
            //I tried to instantiate a new animal here, create the name and eats properties here and do the writelog for the name and eats here so that I did not have to write those properties into each of the instances below but it would not work. 
            
            switch (args[2])
            {
                case "iquana":
                    firstAnimal = new disosaurusDorsalis
                    {
                        color = "green",
                        teeth = true,
                        name = args[0],
                        eats = args[1]
                    };
                    Console.WriteLine(firstAnimal.greet());
                    //I actually did the override in the first assignment because I wanted to print the name from the animal class as well as the properties of the species. If I had done a Console.WriteLine($"This desert iquana is {this.color} and it is {this.teeth} that he has teeth! Hello {this.name}, would you like some {this.eats}?") then I would not have had to override)
                    break;
                case "horse":
                    firstAnimal = new equusFerusCaballus
                    {
                        furColor = "black",
                        maneColor = "tan",
                        name = args[0],
                        eats = args[1]
                    };
                    Console.WriteLine(firstAnimal.greet());
                    break;
                case "bird":
                    firstAnimal = new CardinalisCardinalis
                    {
                        wings = true,
                        numberFeet = 2,
                        name = args[0],
                        eats = args[1]
                    };
                    Console.WriteLine(firstAnimal.greet());
                    break;
                case "whale":
                    firstAnimal = new balaenopteraMusculus
                    {
                        skinColor = "grey",
                        numFins = 2,
                        name = args[0],
                        eats = args[1]
                    };
                    Console.WriteLine(firstAnimal.greet());
                    break;
            }
        }
    }
}

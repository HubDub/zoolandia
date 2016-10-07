using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main()
        {
            
    //creating instances of iquanas
            disosaurusDorsalis firstIguana = new disosaurusDorsalis()
            {
                color = "green",
                teeth = true,
                name = "Billy",
                eats = "insects"
            };
            Console.WriteLine(firstIguana.greet());
            Console.WriteLine($"His hero is {firstIguana.hero}");

            disosaurusDorsalis secondIguana = new disosaurusDorsalis("Greg")
            {
                color = "green",
                teeth = true,
                name = "Billy",
                eats = "insects"
            };
            Console.WriteLine(secondIguana.greet());
            Console.WriteLine($"His hero is {secondIguana.hero}");

            disosaurusDorsalis thirdIguana = new disosaurusDorsalis(10)
            {
                color = "green",
                teeth = true,
                name = "Billy",
                eats = "insects"
            };
            Console.WriteLine(thirdIguana.greet());
            Console.WriteLine($"He has {thirdIguana.toes} toes.");

            disosaurusDorsalis fourthIguana = new disosaurusDorsalis("Greg", 10)
            {
                color = "green",
                teeth = true,
                name = "Billy",
                eats = "insects"
            };
            Console.WriteLine(fourthIguana.greet());
            Console.WriteLine($"His hero is {secondIguana.hero} and He has {fourthIguana.toes} toes.");
            
    //creating instances of horses
            equusFerusCaballus firstHorse = new equusFerusCaballus()
            {
                furColor = "black",
                maneColor = "tan",
                name = "Dan",
                eats = "hay"
            };
            Console.WriteLine(firstHorse.greet());
            Console.WriteLine($"His hero is {firstHorse.hero}.");

            equusFerusCaballus secondHorse = new equusFerusCaballus("Joe")
            {
                furColor = "black",
                maneColor = "tan",
                name = "Dan",
                eats = "hay"
            };
            Console.WriteLine(secondHorse.greet());
            Console.WriteLine($"His hero is {secondHorse.hero}.");       

            equusFerusCaballus thirdHorse = new equusFerusCaballus(0)
            {
                furColor = "black",
                maneColor = "tan",
                name = "Dan",
                eats = "hay"
            };
            Console.WriteLine(thirdHorse.greet());
            Console.WriteLine($"He has {thirdHorse.toes} toes.");         

            equusFerusCaballus fourthHorse = new equusFerusCaballus("Joe", 0)
            {
                furColor = "black",
                maneColor = "tan",
                name = "Dan",
                eats = "hay"
            };
            Console.WriteLine(fourthHorse.greet());
            Console.WriteLine($"His hero is {fourthHorse.hero} and he has {fourthHorse.toes} toes.");        

    //creating instances of birds
            cardinalisCardinalis firstBird = new cardinalisCardinalis()
            {
                wings = true,
                numberFeet = 2,
                name = "Dolly",
                eats = "berries"
            };
            Console.WriteLine(firstBird.greet());
            Console.WriteLine($"Her hero is {firstBird.hero}.");

            cardinalisCardinalis secondBird = new cardinalisCardinalis("Ryan")
            {
                wings = true,
                numberFeet = 2,
                name = "Dolly",
                eats = "berries"
            };
            Console.WriteLine(secondBird.greet());
            Console.WriteLine($"Her hero is {secondBird.hero}.");

            cardinalisCardinalis thirdBird = new cardinalisCardinalis(6)
            {
                wings = true,
                numberFeet = 2,
                name = "Dolly",
                eats = "berries"
            };
            Console.WriteLine(thirdBird.greet());
            Console.WriteLine($"She has {thirdBird.toes} toes.");      

            cardinalisCardinalis fourthBird = new cardinalisCardinalis("Ryan", 6)
            {
                wings = true,
                numberFeet = 2,
                name = "Dolly",
                eats = "berries"
            };
            Console.WriteLine(fourthBird.greet());
            Console.WriteLine($"Her hero is {fourthBird.hero} and she has {fourthBird.toes} toes.");        
            
    //creating instances of whales
            balaenopteraMusculus firstWhale = new balaenopteraMusculus()
            {
                skinColor = "grey",
                numFins = 2,
                name = "Ellen",
                eats = "krill"
            };
            Console.WriteLine(firstWhale.greet());
            Console.WriteLine($"Her hero is {firstWhale.hero}.");

            balaenopteraMusculus secondWhale = new balaenopteraMusculus("Scott")
            {
                skinColor = "grey",
                numFins = 2,
                name = "Ellen",
                eats = "krill"
            };
            Console.WriteLine(secondWhale.greet());
            Console.WriteLine($"Her hero is {secondWhale.hero}.");

            balaenopteraMusculus thirdWhale = new balaenopteraMusculus(0)
            {
                skinColor = "grey",
                numFins = 2,
                name = "Ellen",
                eats = "krill"
            };
            Console.WriteLine(thirdWhale.greet());
            Console.WriteLine($"She has {thirdWhale.toes} toes.");

            balaenopteraMusculus fourthWhale = new balaenopteraMusculus("Scott", 0)
            {
                skinColor = "grey",
                numFins = 2,
                name = "Ellen",
                eats = "krill"
            };
            Console.WriteLine(fourthWhale.greet());
            Console.WriteLine($"Her hero is {fourthWhale.hero} and she has {fourthWhale.toes} toes.");

        }
    }
}

namespace Zoolandia.Animals
{
    public class ElephasMaximusIndicus : Species
    {
        public ElephasMaximusIndicus()
        {
            this.url = "https://en.wikipedia.org/wiki/Indian_elephant";
            this.scientificName = "Elephas Maximus Indicus";
            this.commonName = "Indian Elephant";
            this.genus = new Elephas();
        }
    }
}
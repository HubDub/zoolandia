namespace Zoolandia.Animals
{
    public class BalaenopteraMusculus : Species
    {
        public BalaenopteraMusculus()
        {
            this.url = "https://en.wikipedia.org/wiki/Blue_whale";
            this.scientificName = "Balaenoptera Musculus";
            this.commonName = "Blue Whale";
            this.genus = new Balaenoptera();
        }
    }
}
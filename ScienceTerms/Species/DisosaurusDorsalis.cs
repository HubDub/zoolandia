namespace Zoolandia.Animals
{
    public class DisosaurusDorsalis : Species
    {
        public DisosaurusDorsalis()
        {
            this.url = "https://en.wikipedia.org/wiki/Desert_iguana";
            this.scientificName = "Disosaurus Dorsalis";
            this.commonName = "Desert Iguana";
            this.genus = new Disosaurus();
        }
    }
}
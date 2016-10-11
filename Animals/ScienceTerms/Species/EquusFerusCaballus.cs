namespace Zoolandia.Animals
{
    public class EquusFerusCaballus : Species
    {
        public EquusFerusCaballus()
        {
            this.url = "https://en.wikipedia.org/wiki/Arabian_horse";
            this.scientificName = "EquusFerusCaballus";
            this.commonName = "Arabian Horse";
            this.genus = new Equus();
        }
    }
}
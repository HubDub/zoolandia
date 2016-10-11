namespace Zoolandia.Animals
{
    public class PantheraLeo : Species
    {
        public PantheraLeo()
        {
            this.url = "https://en.wikipedia.org/wiki/Lion";
            this.scientificName = "Panthera Leo";
            this.commonName = "African Lion";
            this.genus = new Panthera();
        }
    }
}
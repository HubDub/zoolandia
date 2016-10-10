namespace Zoolandia.Animals
{
    public class Species: ScienceTerms
    {
        private Genus _genus;

        public Genus genus
        {
            get 
            {
                return _genus;
            }
            set
            {
                _genus = value;
            }
        }
    }
}
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

//in this file we are making species inherit from ScienceTerms so that it inherits those properites. in addition, we're creating a private genus variable that has all the inherited properties and then creating a public genus variable that can only return the private variable and set the variable based on the value put into the constructor - this way there is no other way to change these properties. only through the constructor. 
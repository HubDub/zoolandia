namespace Zoolandia.Animals
{
    public class Genus: ScienceTerms
    {
        //all this does is make Genus inherit the properties located in ScienceTerms. this is for both readibility for future programmers and also so that we don't have to create these properties for both genus and species, they can both inherit the same properties from ScienceTerms and then we only have to define the variables in the individual genus and species classes of the critters
    }
}
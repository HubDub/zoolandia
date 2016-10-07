using System;

namespace Zoolandia.Animals
{
  public class cardinalisCardinalis: Animal 
  {

    // CardinalisCardinalis = new Animal; but doesn't the above do that?
    public bool wings {get; set;}
    public int numberFeet {get; set;}

    public string hero {get; set;}
    public int toes {get; set;}
    
    public cardinalisCardinalis ()
    {
      this.hero = "Foghorn Leghorn";
    }

    public cardinalisCardinalis (string hero1)
    {
      this.hero = hero1;
    }
    public cardinalisCardinalis (int toes1)
    {
      this.toes = toes1;
    }
    

    public override string greet()
    {
      return $"This redbird has wings, {this.wings}, and also has {this.numberFeet} feet! {base.greet()}";
    }
  }
} 
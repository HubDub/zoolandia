using System;

namespace Zoolandia.Animals
{
  public class CardinalisCardinalis: Animal 
  {

    // CardinalisCardinalis = new Animal; but doesn't the above do that?
    public bool wings {get; set;}
    public int numberFeet {get; set;}

    public string hero {get; set;}
    public CardinalisCardinalis ()
    {
      this.hero = "Foghorn Leghorn";
    }

    public override string greet()
    {
      return $"This redbird has wings, {this.wings}, and also has {this.numberFeet} feet! \nHis hero is {this.hero}.\n{base.greet()}";
    }
  }
} 
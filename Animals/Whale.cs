using System;

namespace Zoolandia.Animals
{
  public class balaenopteraMusculus: Animal 
  {
    public string skinColor {get; set;}
    public int numFins {get; set;}
    public string hero {get; set;}
    public int toes {get; set;}
    public balaenopteraMusculus ()
    {
      this.hero = "Moby Dick";
    }

    public balaenopteraMusculus (string hero1)
    {
      this.hero = hero1;
    }
    public balaenopteraMusculus (int toes1)
    {
      this.toes = toes1;
    }
    

    public override string greet()
    {
      return $"This blue whale is {this.skinColor} in color and has {this.numFins} fins! {base.greet()}";
    }
  }
}
using System;

namespace Zoolandia.Animals
{

  public class Balaenoptera: Animal
  {
    public int tail = 1;
    public bool skeleton = true;

    public string blooded = "warm";

    public override string greet()
    {
      return $"He has {this.tail} tail, is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. {base.greet()}";
    }
  }

  public class BalaenopteraMusculus: Balaenoptera 
  {
    public string skinColor = "blue";
    public int numFins = 3;
    public string hero = "Moby Dick";

    //constructor
    // public BalaenopteraMusculus (hero1)
    // {
    //   this.hero = hero1;
    // }

    public override string greet()
    {
      return $"This blue whale is {this.skinColor} in color and has {this.numFins} fins! {base.greet()}";
    }
    public string singing()
    {
      return $"He is being quiet";
    }
    public string singing(string talk, int number)
    {
      return $"He sang you {number} songs.";
    }
  }
}
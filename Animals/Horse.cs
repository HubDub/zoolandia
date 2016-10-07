using System;

namespace Zoolandia.Animals
{
  
  public class Equus: Animal
  {
    public int legs = 4;
    public bool skeleton = true;

    public string blooded = "warm";

    public override string greet()
    {
      return $"He has {this.legs} legs, is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. {base.greet()}";
    }
  }
  public class EquusFerusCaballus: Equus 
  {
    public string furColor = "black";
    public string maneColor = "tan";
    public string hero = "Mr. Ed";

    //below is constructor
    // public equusFerusCaballus ()
    // {
    //   this.hero = "Mr. Ed";
    // }

    public override string greet()
    {
      return $"This Arabian horse has {this.furColor} colored fur with a {this.maneColor} mane! {base.greet()}";
    }

    public string talking()
    {
      return $"He is giving you the silent treatment!";
    }
    public string talking(string talk)
    {
      return $"He is naying at you.";
    }
  }
} 
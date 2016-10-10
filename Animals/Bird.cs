namespace Zoolandia.Animals
{

  public class Bird : Animal
  {
    public int legs = 2;
    public bool skeleton = true;

    public string blooded = "warm";
    public bool wings = true;
    public int numberFeet = 2;

    public string hero = "Foghorn Leghorn";

    public override string greet()
    {
      return $"This redbird has wings, {this.wings}, and also has {this.numberFeet} feet! He has {this.legs} legs, is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. {base.greet()}";
    }
 
    public string talking()
    {
      return $"He is giving you the silent treatment!";
    }
    public string talking(string talk)
    {
      return $"He is chirping at you.";
    }
  }
} 
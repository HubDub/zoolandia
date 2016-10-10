namespace Zoolandia.Animals
{
  
  public class Horse: Animal
  {
    public int legs = 4;
    public bool skeleton = true;

    public string blooded = "warm";
    public string furColor = "black";
    public string maneColor = "tan";
    public string hero = "Mr. Ed";

    public override string greet()
    {
      return $"This Arabian horse has {this.furColor} colored fur with a {this.maneColor} mane! He has {this.legs} legs, is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. {base.greet()}";
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
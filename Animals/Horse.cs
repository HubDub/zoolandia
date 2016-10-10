namespace Zoolandia.Animals
{
  
  public class Horse: Animal, IWalk
  {
    public int legs = 4;
    public bool skeleton = true;

    public string blooded = "warm";
    public string furColor = "black";
    public string maneColor = "tan";
    public string hero = "Mr. Ed";

    public double groundSpeed {get; set;}

    public Horse()
    { 
      groundSpeed = 30;
    }

    public override string greet()
    {
      return $"This Arabian horse has {this.furColor} colored fur with a {this.maneColor} mane! He has {this.legs} legs, is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. He can run around {this.groundSpeed} mph. {base.greet()}";
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
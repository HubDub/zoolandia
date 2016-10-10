namespace Zoolandia.Animals
{

  public class Whale: Animal, ISwim
  {
    public int tail = 1;
    public bool skeleton = true;

    public string blooded = "warm";
    public string skinColor = "blue";
    public int numFins = 3;
    public string hero = "Moby Dick";

    public double swimSpeed {get; set;}

    public Whale()
    {
      swimSpeed = 30;
    }

    public override string greet()
    {
      return $"This blue whale is {this.skinColor} in color and has {this.numFins} fins! He has {this.tail} tail, is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. He can swim up to {this.swimSpeed} mph. {base.greet()}";
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
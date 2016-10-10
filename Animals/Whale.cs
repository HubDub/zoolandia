namespace Zoolandia.Animals
{

  public class Whale: Animal
  {
    public int tail = 1;
    public bool skeleton = true;

    public string blooded = "warm";
    public string skinColor = "blue";
    public int numFins = 3;
    public string hero = "Moby Dick";

    public override string greet()
    {
      return $"This blue whale is {this.skinColor} in color and has {this.numFins} fins! He has {this.tail} tail, is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. {base.greet()}";
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
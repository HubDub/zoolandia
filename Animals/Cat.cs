namespace Zoolandia.Animals
{

  public class Lion: Animal, IWalk
  {
    public int tail = 1;
    public bool skeleton = true;

    public string blooded = "warm";

    public string furColor = "tan";

    public string maneColor = "orangy";

    public string hero = "Pumbaa";

    public double groundSpeed {get; set;}

    public Lion()
    {
      groundSpeed = 50;
    }
    public override string greet()
    {
      return $"This lion is {this.furColor} in color, with a {this.maneColor} colored mane. He has {this.tail} tail, is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. He can run up to {this.groundSpeed} mph. {base.greet()}";
    }
    public string activity()
    {
      return $"He is sleeping.";
    }
    public string activity(string move)
    {
      return $"He is pouncing through the grass.";
    }
    public string activity(string move, string animal)
    {
      return $"He just pounced on that {animal}.";
    }
    public string activity(string move, string animal, bool tripped)
    {
      return $"He pounced on that {animal} and then tripped and fell down. Clumsy lion!";
    }
  }
}
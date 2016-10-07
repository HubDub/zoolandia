using System;

namespace Zoolandia.Animals
{

  public class Panthera: Animal
  {
    public int tail = 1;
    public bool skeleton = true;

    public string blooded = "warm";

    public override string greet()
    {
      return $"He has {this.tail} tail, is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. {base.greet()}";
    }
  }
  
  public class PantheraLeo: Panthera 
  {
    public string furColor = "tan";

    public string maneColor = "orangy";

    public string hero = "Pumbaa";

    //constructor
    // public BalaenopteraMusculus ()
    // {
    //   this.hero = "Moby Dick";
    // }

    public override string greet()
    {
      return $"This lion is {this.furColor} in color, with a {this.maneColor} colored mane. {base.greet()}";
    }

    public string action()
    {
      return $"He is sleeping.";
    }
    public string action(string move)
    {
      return $"He is pouncing through the grass.";
    }
    public string action(string move, string animal)
    {
      return $"He just pounced on that {animal}.";
    }
    public string action(string move, string animal, bool tripped)
    {
      return $"He pounced on that {animal} and then tripped and fell down. Clumsy lion!";
    }
  }
}
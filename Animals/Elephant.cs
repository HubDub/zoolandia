using System;

namespace Zoolandia.Animals
{

  public class Elephant: Animal
  {
    public int tail = 1;
    public bool skeleton = true;

    public string blooded = "warm";
    public string skinColor = "gray";

    public string earShape = "triangular";
    public int legs = 4;
    public string hero = "Dumbo";

    public override string greet()
    {
      return $"This Indian Elephant is {this.skinColor} in color, has {this.legs} legs and his ears are {this.earShape} shaped!  He has {this.tail} tail, is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. {base.greet()}";
    }
 
    public string running()
    {
      return $"He is sitting still.";
    }

    public string running(string run)
    {
      return $"He is running across the grass!";
    }

    public string running(string run, int distance)
    {
      return $"He just ran {distance} miles!";
    }
  }
}
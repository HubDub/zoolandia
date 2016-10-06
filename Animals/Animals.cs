using System;
using Zoolandia;

namespace Zoolandia.Animals
{
  public class Animal
  {
    public string name {get; set;}
    public string eats {get; set;}

    public virtual string greet()
    {
      return $"Hello {this.name}, would you like some {this.eats}?";
    }
  }
}

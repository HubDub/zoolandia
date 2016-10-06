using System;

namespace Zoolandia.Animals
{
  public class balaenopteraMusculus: Animal 
  {
    public string skinColor {get; set;}
    public int numFins {get; set;}

    public override string greet()
    {
      return $"This blue whale is {this.skinColor} in color and has {this.numFins} fins!\n{base.greet()}";
    }
  }
} 
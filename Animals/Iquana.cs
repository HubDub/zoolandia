using System;

namespace Zoolandia.Animals
{
  public class disosaurusDorsalis: Animal 
  {
    public string color {get; set;}
    public bool teeth {get; set;}

    public override string greet()
    {
      return $"This desert iquana is {this.color} and it is {this.teeth} that he has teeth!\n{base.greet()}";
    }
  }
} 
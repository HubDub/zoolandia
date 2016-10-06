using System;

namespace Zoolandia.Animals
{
  public class disosaurusDorsalis: Animal 
  {
    public string color {get; set;}
    public bool teeth {get; set;}
    
    public string hero {get; set;}
    public disosaurusDorsalis ()
    {
      this.hero = "Godzilla";
    }

    public override string greet()
    {
      return $"This desert iquana is {this.color} and it is {this.teeth} that he has teeth! \nHis hero is {this.hero}.\n{base.greet()}";
    }
  }
} 
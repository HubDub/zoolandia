using System;

namespace Zoolandia.Animals
{
  public class disosaurusDorsalis: Animal 
  {
    public string color {get; set;}
    public bool teeth {get; set;}
    
    public string hero {get; set;}
    public int toes {get; set;}
    public disosaurusDorsalis ()
    {
      this.hero = "Godzilla";
    }
    public disosaurusDorsalis (string hero1)
    {
      this.hero = hero1;
    }
    public disosaurusDorsalis (int toes1)
    {
      this.toes = toes1;
    }
    public disosaurusDorsalis (string hero1, int toes1)
    {
      this.hero = hero1;
      this.toes = toes1;
    }

    public override string greet()
    {
      return $"This desert iquana is {this.color} and it is {this.teeth} that he has teeth! {base.greet()}";
    }
  }
} 
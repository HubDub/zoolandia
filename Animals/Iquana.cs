using System;

namespace Zoolandia.Animals
{

  //below is the genus class
  public class Disosaurus: Animal
  {
    //below are properties of the iquana genus
    public int legs = 4;
    public bool skeleton = true;

    public string blooded = "cold";

    //below is the greet method that both overrides the animal class greet and is overriden by the species class greet. it then calls for the animal class greeting to run.
    public override string greet()
    {
      return $"He has {this.legs} legs, is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. {base.greet()}";
    }
    
    //below are overloaded methods. when an argument is passed the program runs the second method
    public string sleeps()
    {
      return $"This iquana never sleeps.";
    }
    public string sleeps(string asleep)
    {
      return$"This iguana is asleep!";
    }
    
  }

  //below is the species class
  public class DisosaurusDorsalis: Disosaurus 
  {
    public string color = "tan";
    public bool teeth = true;
    
    public string hero = "Godzilla";
    public int toes = 10;

    //this is a constructor
    // public DisosaurusDorsalis ()
    // {
    //   this.hero = "Godzilla";
    // }

    //below is a greet method that overrides the greet method in the genus class and then calls for that method to run.
    public override string greet()
    {
      return $"This desert iquana is {this.color} and it is {this.teeth} that he has teeth! {base.greet()}";
    }

  }
} 
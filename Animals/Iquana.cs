namespace Zoolandia.Animals
{

    public class Iguana: Animal
  {
    
    public bool skeleton = true;

    public string blooded = "cold";

    public string color = "tan";
    
    public string hero = "Godzilla";


    public override string greet()
    {
      return $"The iguana is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. He is {this.color}. {base.greet()}";
    }
  }
} 
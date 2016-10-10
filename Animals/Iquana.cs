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

//here we both create and set the values for properties on Iguana. we also create the method greet for this class. This greet method also calls the base greet, so after it is done console writing it will call the greet function located in the Animal class. 
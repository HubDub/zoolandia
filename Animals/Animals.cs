namespace Zoolandia.Animals
{

    //below is the basic animal class with two properties that are set when a new instance of the species - which inherits from this - is created. it also contains a method
    public class Animal
  {
    public string name {get; set;}
    public string food {get; set;}
    
    public Species species {get; set;}

    public virtual string greet()
    {
      return $"Hello {this.name}, would you like some {this.food}?";
    }

    public string action()
    {
      return $"{this.name} is sleeping!";
    }
    public string action(string food)
    {
      return $"{this.name} is eating {this.food}!";
    }
  }
}

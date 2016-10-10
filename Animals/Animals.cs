namespace Zoolandia.Animals
{

    //below is the basic animal class with properties 
    public class Animal
  {
    public string name {get; set;}
    public string food {get; set;}
    
    public Species species {get; set;}

    //and methods. the greet method will be overwritten by any greet method on the specific animal page. 
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

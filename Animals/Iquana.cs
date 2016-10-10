namespace Zoolandia.Animals
{

    public class Iguana: Animal, IWalk
  {
    
    public bool skeleton = true;

    public string blooded = "cold";

    public string color = "tan";
    
    public string hero = "Godzilla";
    //I am required to put a groundspeed in but I can't set the value because it makes me do the get/set just as I did in the interface and I cant assign the value in the interface.
    public double groundSpeed {get; set;}

    //I created a constructor so that I could assign a groundspeed value to all my iguanas
    public Iguana()
      {
        groundSpeed = 2;
      }

    public override string greet()
    {
      return $"The iguana is {this.blooded} blooded, and it is {this.skeleton} that he has a skeleton. He is {this.color} and can move {this.groundSpeed} inches per second. {base.greet()}";
    }
  }
} 

//here we both create and set the values for properties on Iguana. we also create the method greet for this class. This greet method also calls the base greet, so after it is done console writing it will call the greet function located in the Animal class. 
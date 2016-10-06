using System;

namespace Zoolandia.Animals
{
  public class equusFerusCaballus: Animal 
  {
    public string furColor {get; set;}
    public string maneColor {get; set;}

    public override string greet()
    {
      return $"This Arabian horse has {this.furColor} colored fur with a {this.maneColor} mane!\n{base.greet()}";
    }
  }
} 
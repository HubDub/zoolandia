using System;

namespace Zoolandia.Animals
{
  public class equusFerusCaballus: Animal 
  {
    public string furColor {get; set;}
    public string maneColor {get; set;}
    public string hero {get; set;}
    public equusFerusCaballus ()
    {
      this.hero = "Mr. Ed";
    }

    public override string greet()
    {
      return $"This Arabian horse has {this.furColor} colored fur with a {this.maneColor} mane! \nHis hero is {this.hero}.\n{base.greet()}";
    }
  }
} 
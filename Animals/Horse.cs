using System;

namespace Zoolandia.Animals
{
  public class equusFerusCaballus: Animal 
  {
    public string furColor {get; set;}
    public string maneColor {get; set;}
    public string hero {get; set;}

    public int toes {get; set;}
    public equusFerusCaballus ()
    {
      this.hero = "Mr. Ed";
    }

    public equusFerusCaballus (string hero1)
    {
      this.hero = hero1;
    }
    public equusFerusCaballus (int toes1)
    {
      this.toes = toes1;
    }
    public equusFerusCaballus (string hero1, int toes1)
    {
      this.hero = hero1;
      this.toes = toes1;
    }

    public override string greet()
    {
      return $"This Arabian horse has {this.furColor} colored fur with a {this.maneColor} mane! {base.greet()}";
    }
  }
} 
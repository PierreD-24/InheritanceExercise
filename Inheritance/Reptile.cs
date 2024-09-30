namespace Inheritance;

public class Reptile : Animal
{
   public bool ColdBlooded { get; set; } = true;
   public bool HasScales { get; set; } = true;
   public int Legs { get; set; } = 4;
   public string Type { get; set; }
}
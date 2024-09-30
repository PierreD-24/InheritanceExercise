namespace Inheritance;

public class Bird : Animal
{
    public bool HasFeathers { get; set; } = true;
    public bool CanFly { get; set; } = true;
    public string ChirpSound { get; set; }
    public bool HasBeak { get; set; } = true;
}
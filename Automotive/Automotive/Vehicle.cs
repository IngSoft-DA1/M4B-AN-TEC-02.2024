namespace Automotive;

public class Vehicle 
{
    public int DoorQuanitity { get; set; }
    public string Color { get; set; }

    public Vehicle(int doorQuanitity, string color)
    {
        DoorQuanitity = doorQuanitity;
        Color = color;
    }

    public virtual void TurnOn()
    {
        Console.WriteLine("Remember to override this method to print the correct information");
        
    }
}
namespace Automotive;

public class Vehicle 
{
    public int DoorQuantity { get; set; }
    public string Color { get; set; }

    public Vehicle(int doorQuantity, string color)
    {
        DoorQuantity = doorQuantity;
        Color = color;
    }

    public virtual void TurnOn()
    {
        Console.WriteLine("Remember to override this method to print the correct information");
        
    }
}
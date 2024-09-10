
namespace Automotive;

public class Truck: Vehicle
{
    public Truck(int doorQuantity, string color) : base(doorQuantity, color)
    {
    }
    
    public override void TurnOn()
    {
        Console.WriteLine($"This truck is of color {Color} and has {DoorQuantity} doors");
    }
}
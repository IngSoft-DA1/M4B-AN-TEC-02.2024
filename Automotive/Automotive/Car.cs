

namespace Automotive;

public class Car : Vehicle
{
    public Car(int doorQuantity, string color) : base(doorQuantity, color)
    {
    }

    public override void TurnOn()
    {
        Console.WriteLine($"This car is of color {Color} and has {DoorQuantity} doors");
    }
}
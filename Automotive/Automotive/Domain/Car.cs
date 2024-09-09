namespace Domain;

public class Car : Vehicle
{
    public override void TurnOf()
    {
        Console.WriteLine("turning of radio first");
        base.TurnOf();
    }
}

public class Truck : Vehicle
{
    public bool Is4X4;

    public Truck(bool Is4X4)
    {
        Is4X4 = this.Is4X4;
    }
    public override void TurnOf()
    {
        if(Is4X4)
            Console.WriteLine("turning of 4x4");
        base.TurnOf();
    }
}
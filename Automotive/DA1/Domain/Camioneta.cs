namespace Domain;

public class Camioneta: Vehicle
{
    public Camioneta(int cantPuertas, string colorChasis) : base(cantPuertas, colorChasis)
    {
    }
    
    public override void Encender()
    {
        Console.WriteLine($"Esto es un camioneta con cant puertas {CantPuertas} y color {ColorChasis}");
        ;
    }
}
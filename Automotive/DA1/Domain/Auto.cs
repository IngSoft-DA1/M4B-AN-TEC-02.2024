namespace Domain;

public class Auto : Vehicle
{
    public Auto(int cantPuertas, string colorChasis) : base(cantPuertas, colorChasis)
    {
    }

    public void Encender()
    {
        Console.WriteLine($"Esto es un auto con cant puertas {CantPuertas} y color {ColorChasis}");
        ;
    }
}
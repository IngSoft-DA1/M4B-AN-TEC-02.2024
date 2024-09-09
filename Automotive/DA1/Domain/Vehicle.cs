namespace Domain;

public class Vehicle
{
    public string ColorChasis;
    public int CantPuertas;

    public Vehicle(int cantPuertas, string colorChasis)
    {
        ColorChasis = colorChasis;
        CantPuertas = cantPuertas;

    }


    public virtual void Encender()
    {
        Console.WriteLine("deberia");
    }
}
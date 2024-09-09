namespace Domain;

public class Vehicle
{
    public int Tires;
    public string Color;

    public static void UseParams(params int[] list){
        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine(i);
        }

    }
}


enum Brand
{
    Mercedes,
    Toyota,
    Ford,
    Honda,
    Chevrolet,
    Nissan
}

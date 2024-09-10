
using Automotive;

List<Vehicle> list = new List<Vehicle>()
{
    new Car(5, "red"),
    new Car(3, "Purple"),
    new Car(4, "green"),
    new Truck(5, "red"),
    new Truck(3, "Purple"),
    new Truck(4, "green"),
};


foreach (var v in list)
{
    v.TurnOn();
}


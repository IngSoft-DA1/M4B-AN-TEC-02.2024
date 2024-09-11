using Domain;

List<Vehicle> vehicles = new List<Vehicle>();

Car car = new Car(4,"red");
Van van = new Van(2,"green");

vehicles.Add(car);
vehicles.Add(van);

foreach (var vehicle in vehicles)
{
    vehicle.TurnOn();
}
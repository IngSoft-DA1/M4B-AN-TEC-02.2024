// See https://aka.ms/new-console-template for more information

using Domain;

Console.WriteLine("Hello, World!");

Auto a = new Auto(4, "rojo");
Camioneta c = new Camioneta(4, "amarrillo");

List<Vehicle> lista = new List<Vehicle>();
a.Encender();
lista.Add(a);
lista.Add(c);

foreach (var vec in lista)
{
    vec.Encender();
}
namespace Domain;

public class Student : Person
{
    public Student(string name, string lastName) : base(name, lastName)
    {
    }
    
    public void Method()
    {
        Console.WriteLine("this should be printed");
    }
}
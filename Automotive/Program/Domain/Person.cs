namespace Domain;

public class Person
{
    public string Name { get; set; }
    private string _lastName;

    public string LastName
    {
        get => _lastName;
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Last Name cannot be null or empty");
            _lastName = value;
        }
    }
    
    public string FullName
    {
        get => $"{Name} {LastName}";
    }
    
    public Person(string name, string lastName)
    {
        Name = name;
        LastName = lastName;
    }

    public void Method()
    {
        Console.WriteLine("this should be overidable");
    }
}
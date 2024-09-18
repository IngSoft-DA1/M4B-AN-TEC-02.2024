namespace UnitTests;

public class Person
{
    private string _name;
    private string _lastName;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Name cannot be null");
            _name = value;
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Name cannot be null");
            _lastName = value;
        }
    }
    public string FullName => $"{Name} {LastName}";

    public int GetFullNameLength()
    {
        if (FullName.Length < 5)
            throw new ArgumentException();
        return FullName.Length;
    }
    
}
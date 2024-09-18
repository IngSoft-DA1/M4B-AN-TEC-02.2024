using UnitTests;

namespace Domain.Tests;

[TestClass]
public class PersonTests
{
    [TestMethod]
    public void Valid_Name_Test()
    {
        // Arrange
        var name = "Jhon";
        var lastName = "Doe";

        // Act
        var p = new Person()
        {
            Name = name,
            LastName = lastName
        };

        // Assert
        Assert.AreEqual(name, p.Name);
    }

    [TestMethod]
    public void Valid_Last_Name_Test()
    {
        // Arrange
        var name = "Jhon";
        var lastName = "Doe";

        // Act
        var p = new Person()
        {
            Name = name,
            LastName = lastName
        };

        // Assert
        Assert.AreEqual(lastName, p.LastName);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Invalid_Null_Name_Test()
    {
        // Arrange
        var lastName = "Doe";

        // Act
        var p = new Person()
        {
            LastName = lastName,
            Name = ""
        };

        // Assert - exception expected
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Invalid_Null_Last_Name_Test()
    {
        // Arrange
        var name = "Jhon";

        // Act
        var p = new Person()
        {
            Name = name,
            LastName = ""
        };

        // Assert - exception expected
    }

    [TestMethod]
    public void FullName_Test()
    {
        // Arrange
        var name = "Jhon";
        var lastName = "Doe";
        var fullName = $"{name} {lastName}";

        // Act
        var p = new Person()
        {
            Name = name,
            LastName = lastName
        };

        // Assert
        Assert.AreEqual(fullName, p.FullName);
    }

    [TestMethod]
    public void GetFullNameLength_Test()
    {
        // Arrange
        var name = "Jhon";
        var lastName = "Doe";
        var fullNameLength = $"{name} {lastName}".Length;

        // Act
        var p = new Person()
        {
            Name = name,
            LastName = lastName
        };
        var resp = p.GetFullNameLength();

        // Assert
        Assert.AreEqual(fullNameLength, resp);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GetFullNameLength_Error_Less_Than_Five()
    {
        // Arrange
        var name = "J";
        var lastName = "D";

        // Act
        var p = new Person()
        {
            Name = name,
            LastName = lastName
        };

        // Act & Assert - exception expected
        p.GetFullNameLength();
    }
}

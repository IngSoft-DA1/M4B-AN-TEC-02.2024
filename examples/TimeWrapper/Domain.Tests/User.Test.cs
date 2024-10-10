namespace Domain.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void UserBirthDateValid()
    {
        // al usar el dateTime wrapper yo puedo cambiar el valor
        // que se considera como presente entocnes puedo hacer algo asi:
        
        User u = new User();
        // mi fecha actual es en el 3012
        DateTimeWrapper.FixedDate = new DateTime(3012, 12, 10);
        //la fecha que assigno al user si bien es en el futuro, para  mi wrapper es en el pasado 
        var futureBirthDate = new DateTime(3000, 12,10);
        u.BirthDay = futureBirthDate;
        
        Assert.AreEqual(u.BirthDay,futureBirthDate);
    }
}
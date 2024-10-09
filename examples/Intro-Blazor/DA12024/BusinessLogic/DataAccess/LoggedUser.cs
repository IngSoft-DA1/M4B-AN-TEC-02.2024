using Domain;

namespace BusinessLogic.DataAccess;

public static class LoggedUser
{
    public static User? Current { get; set; }
}
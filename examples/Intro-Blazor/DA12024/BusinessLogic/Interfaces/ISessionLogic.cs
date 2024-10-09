using Domain;

namespace BusinessLogic.Interfaces;

public interface ISessionLogic
{
    void Login(string email, string password);
    User? GetLoggedUser();
}
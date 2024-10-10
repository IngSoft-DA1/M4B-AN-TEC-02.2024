namespace Domain;

public class User
{
    private DateTime _birthDay;
    public DateTime BirthDay { get=>_birthDay;
        set
        {
            if (value >= DateTimeWrapper.Now())
            {
                throw new ArgumentException("You cant be born on the future");
            }
            _birthDay = value;
        }
    }
}
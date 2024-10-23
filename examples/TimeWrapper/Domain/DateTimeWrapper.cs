namespace Domain;

public class DateTimeWrapper
{
    public static DateTime? FixedDate;
    public static DateTime Now()
    {
        return FixedDate ?? DateTime.Now;
    }
    
}
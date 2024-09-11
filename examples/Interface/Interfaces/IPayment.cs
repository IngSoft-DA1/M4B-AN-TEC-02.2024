namespace Interfaces;

public interface IPayment
{
    void ProcessPayment(String cardNumber, String cardBrand);
}
namespace Adapter;

public interface IPaymentProcessor
{
    public bool Pay(int amount);
}
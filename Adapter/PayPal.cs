namespace Adapter;

public class PayPal
{
    public bool SendPayment(decimal amountInCents)
    {
        amountInCents = amountInCents / 100m;
        Console.WriteLine($"PayPal: sent ${amountInCents}");
        return true;
    }
}

public class PayPalAdapter : IPaymentProcessor
{
    private readonly PayPal _payPal;

    public PayPalAdapter(PayPal payPal) => _payPal = payPal;

    public bool Pay(int amount) => _payPal.SendPayment(amount*100);
}

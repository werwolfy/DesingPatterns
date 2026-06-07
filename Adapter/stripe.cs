namespace Adapter;

public class Stripe
{
    public bool Charge(int amount, string username)
    {
        Console.WriteLine($"Stripe: charged {username} ${amount}");
        return true;
    }
}

public class StripeAdapter : IPaymentProcessor
{
    private readonly Stripe _stripe;
    private readonly string _username;

    public StripeAdapter(Stripe stripe, string username)
    {
        _stripe = stripe;
        _username = username;
    }

    public bool Pay(int amount) => _stripe.Charge(amount, _username);
}

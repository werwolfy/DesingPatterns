using Adapter;

var processors = new List<IPaymentProcessor>
{
    new PayPalAdapter(new PayPal()),
    new StripeAdapter(new Stripe(), "user@example.com")
};

foreach (var processor in processors)
{
    processor.Pay(100);
}

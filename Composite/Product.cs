namespace Composite;

public class Product : IComponent
{
    public Product(double price)
    {
        Price = price;
    }
    public double Price { get; set; }

    public double GetPrice()
    {
        return Price;
    }
}
namespace Composite;

public class Box : IComponent
{
    public double Price { get; set; } = 0.3;
    private List<IComponent> children = new List<IComponent>();
    public void Add(IComponent component)
    {
        children.Add(component);
    }
    public void Remove(IComponent component)
    {
        children.Remove(component);
    }


    public double GetPrice()
    {
        double totalPrice = Price;
        foreach (IComponent child in children)
        {
            totalPrice += child.GetPrice();
        }
        return totalPrice;
    }
}
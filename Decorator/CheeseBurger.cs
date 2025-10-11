namespace Decorator;

// Das sind die Concrete Components

public class CheeseBurger : IBurgerIngredients
{
    public double Price { get; set; } = 11;

    public double GetIngredientPrice()
    {
        return  Price;
    }
}
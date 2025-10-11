namespace Decorator;

// Das sind die Concrete Components

public class Hamburger : IBurgerIngredients
{
    public double Price { get; set; } = 10;
    

    public double GetIngredientPrice()
    {
        return  Price;
    }
}
namespace Decorator.Ingredients;

// Das sind die Concrete Decorator

public class Cheese : AIngredients
{
    public Cheese(IBurgerIngredients ingredients)
    {
        Price = 0.1;
        this.Ingredients = ingredients;
    }
    public override double GetIngredientPrice()
    {
        return  Ingredients.GetIngredientPrice() + Price;
    }
}
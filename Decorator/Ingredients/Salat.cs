namespace Decorator.Ingredients;

// Das sind die Concrete Decorator

public class Salat : AIngredients
{
    public Salat(IBurgerIngredients ingredients)
    {
        Price = 0.05;
        this.Ingredients = ingredients;
    }
    public override double GetIngredientPrice()
    {
        return  Ingredients.GetIngredientPrice() + Price;
    }
}
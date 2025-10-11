using System.Runtime.CompilerServices;

namespace Decorator.Ingredients;

// Das sind die Concrete Decorator 

public class Cucumbers : AIngredients
{
    
    public Cucumbers(IBurgerIngredients ingredients)
    {
        Price = 0.2;
        this.Ingredients = ingredients;
    }
    
    public override double GetIngredientPrice()
    {
        return  Ingredients.GetIngredientPrice() + Price;
    }

    
}
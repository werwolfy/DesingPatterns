namespace Decorator.Ingredients;


// Das ist der Base Decorator

public abstract class AIngredients : IBurgerIngredients
{
    public IBurgerIngredients? Ingredients { get; set; }
    public double Price { get; set; }
    
    public virtual double GetIngredientPrice()
    {
        throw new NotImplementedException();
    }
}
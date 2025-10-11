namespace Decorator;

// Das ist die Gemeinsame Schnittstelle  

public interface IBurgerIngredients
{
    public double Price { get; set; }
    public double GetIngredientPrice();
}
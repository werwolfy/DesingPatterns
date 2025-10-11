using Decorator;
using Decorator.Ingredients;

// Das ist der Client

Hamburger hamburger = new();
Console.WriteLine(hamburger.Price);
Salat salat = new Salat(hamburger);
Cucumbers cucumbers1 = new Cucumbers(salat);
Cucumbers cucumbers2 = new Cucumbers(cucumbers1);
Console.WriteLine(cucumbers2.GetIngredientPrice());

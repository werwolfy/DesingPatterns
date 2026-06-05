namespace Builder;

public class CarBuilder : IBuilder
{
    private Car Product { get; set; } = new Car();
    
    public Car Build()
    {
        Car returnCar = Product;
        Reset();
        return returnCar;
    }

    public CarBuilder SetAmountOfDoors(int amountOfDoors)
    {
        Product.AmauntOfDoors = amountOfDoors;
        return this;
    } 
    
    public CarBuilder SetPs(int amountOfDoors)
    {
        Product.Ps = amountOfDoors;
        return this;
    } 
    
    public CarBuilder SetBrand(string brand)
    {
        Product.Brand = brand;
        return this;
    }

    public CarBuilder SetColor(string color)
    {
        Product.Color = color;
        return this;
    }

    public CarBuilder SetSeats(int seats)
    {
        Product.Seats = seats;
        return this;
    }

    public CarBuilder SetIsManaual(bool isManaual)
    {
        Product.IsManaual = isManaual;
        return this;
    }

    public CarBuilder HasHeckspoiler(bool HasHeckspoiler)
    {
        Product.HasHeckspoiler = HasHeckspoiler;
        return this;
    }
    
    public void Reset()
    {
        Product = new Car();
    }
}
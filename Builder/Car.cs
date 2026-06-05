namespace Builder;

public class Car
{
    public int Ps { get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
    public int AmauntOfDoors { get; set; }
    public int Seats { get; set; }
    public bool IsManaual { get; set; }
    public bool HasHeckspoiler { get; set; }

    public Car()
    {
        Ps = 0;
        Brand = "";
        Color = "";
        AmauntOfDoors = 0;
        Seats = 0;
        IsManaual = false;
        HasHeckspoiler = false;
    }
}
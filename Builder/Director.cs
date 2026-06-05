namespace Builder;

public class Director
{
    public CarBuilder CurrentBuilder { get; set; }

    public Director()
    {
        CurrentBuilder = new CarBuilder();
    }

}
namespace Factory;
// Das ist unsere Factory
public class Creator
{
    public Building GetRestaurante()
    {
        Building returnBuilding = new Building() { AmaountOfFloors = 2, AmaountOfWindows = 24, HasPool =  false };
        return returnBuilding;
    }
    public Building GetCasino()
    {
        Building returnBuilding = new Building() { AmaountOfFloors = 5, AmaountOfWindows = 2, HasPool =  false };
        return returnBuilding;
    }
    public Building GetHotel()
    {
        Building returnBuilding = new Building() { AmaountOfFloors = 5, AmaountOfWindows = 255, HasPool =  true };
        return returnBuilding;
    }
}
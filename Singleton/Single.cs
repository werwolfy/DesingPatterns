namespace ConsoleApp1;

public class Single
{
    private static Single instace = null;

    public static Single Instance
    {
        get
        {
            if (instace == null)
            {
                instace = new Single();
            }
            return instace;
        }
    }
    /*public static Single GetSingle()
    {
        if (Instace == null)
        {
            Instace = new Single();
        }
        return new Single();
    }*/

    private Single()
    {
        
    }
    public void DoSomething()
    {
        Console.WriteLine("wir machen etwas");
    }
}
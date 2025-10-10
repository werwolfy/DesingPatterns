namespace Strategy.CompressionMethods;
// Das ist eine der Strategien
public class WinRarStrategy : ICompressionStrategy
{
    string _name = "WinRar";
    public void Compress()
    {
        Console.WriteLine($"Die Datei wurde komprimiert. Vielen Danke für ihr Vertrauen in {_name}");
    }
}
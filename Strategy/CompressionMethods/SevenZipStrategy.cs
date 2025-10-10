namespace Strategy.CompressionMethods;
// Das ist eine der Strategien
public class SevenZipStrategy : ICompressionStrategy
{
    string _name = "SevenZip";
    public void Compress()
    {
        Console.WriteLine($"Die Datei wurde komprimiert. Vielen Danke für ihr Vertrauen in {_name}");
    }
}
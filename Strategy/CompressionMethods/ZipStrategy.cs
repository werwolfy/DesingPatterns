namespace Strategy.CompressionMethods;
// Das ist eine der Strategien
public class ZipStrategy : ICompressionStrategy
{
    string _name = "Zip";
    public void Compress()
    {
        Console.WriteLine($"Die Datei wurde komprimiert. Vielen Danke für ihr Vertrauen in {_name}");
    }
}
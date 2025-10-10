namespace Strategy;
// Das ist die Context
public class Compressor
{
    public Compressor(ICompressionStrategy strategy)
    {
        CompressionStrategy = strategy;
    }
    public ICompressionStrategy CompressionStrategy { get; set; }

    public void Compress()
    {
        CompressionStrategy.Compress();
    }
}
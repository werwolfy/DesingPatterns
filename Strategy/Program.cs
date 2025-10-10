// Strategy Pattern 
// Das ist der Client

using Strategy;
using Strategy.CompressionMethods;


Compressor compressor = new(new SevenZipStrategy());
compressor.Compress();
compressor.CompressionStrategy = new ZipStrategy();
compressor.Compress();
compressor.CompressionStrategy = new WinRarStrategy();
compressor.Compress();
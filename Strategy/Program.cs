// Strategy Pattern 
// Das ist der Client

using Strategy;
using Strategy.CompressionMethods;


Compressor compressor = new(new SevenZipStrategy());
compressor.Compress();
compressor = new(new ZipStrategy());
compressor.Compress();
compressor = new(new WinRarStrategy());
compressor.Compress();
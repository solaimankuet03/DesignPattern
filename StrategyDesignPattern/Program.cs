using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CompressionContext compressionContext = new CompressionContext(new RarCompression());            
            compressionContext.CreateArchive("Test");

            compressionContext.SetStrategy(new ZipCompression());
            compressionContext.CreateArchive("Zip");

            Console.ReadLine();
        }
    }
}

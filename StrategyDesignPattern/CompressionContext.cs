using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class CompressionContext
    {
        public ICompression Compression;

        public CompressionContext(ICompression Compression)
        {
            this.Compression = Compression;
        }
        public void SetStrategy(ICompression Compression)
        {
            this.Compression = Compression;
        }
        

        public void CreateArchive(string compressedArchiveFileName)
        {
            Compression.CompressFolder(compressedArchiveFileName);
        }
    }
}

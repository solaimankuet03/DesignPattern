using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class ZipCompression : ICompression
    {
        public void CompressFolder(string compressArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using Zip approach: '" + compressArchiveFileName
                 + ".zip' file is created");
        }
    }
}

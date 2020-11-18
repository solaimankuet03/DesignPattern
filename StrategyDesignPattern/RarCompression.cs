using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class RarCompression : ICompression
    {
        public void CompressFolder(string compressArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using Rar approach: '" + compressArchiveFileName
                 + ".rar' file is created");
        }
    }
}

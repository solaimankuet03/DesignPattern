using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternRealTimeExample
{
    public class RealImage : IImage
    {
        private string FileName { get; set; }

        public RealImage(string filename)
        {
            this.FileName = filename;
            LoadImageFromDisk();
        }

        public void LoadImageFromDisk()
        {
            Console.WriteLine("Loading Image : " + FileName);
        }

        public void DisplayImage()
        {
            Console.WriteLine("Displaying Image : " + FileName);
        }
    }
}

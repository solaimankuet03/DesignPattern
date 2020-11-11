using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternRealTimeExample
{
    public class RealImageProxy : IImage
    {
        public IImage Image;
        public string FileName { get; set; }

        public RealImageProxy(string filename)
        {
            this.FileName = filename;
        }

        public void DisplayImage()
        {
            if(Image == null)
            {
                Image = new RealImage(FileName);
            }

            Image.DisplayImage();
        }
    }
}

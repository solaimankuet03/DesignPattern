using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class Document //receiver
    {
        public void Open()
        {
            Console.WriteLine("Document opened");
        }

        public void Close()
        {
            Console.WriteLine("Document closed");
        }

        public void Save()
        {
            Console.WriteLine("Document saved");
        }
    }
}

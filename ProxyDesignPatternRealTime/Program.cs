﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternRealTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage Image1 = new RealImageProxy("Tiger Image");

            Console.WriteLine("Image1 calling DisplayImage first time :");
            Image1.DisplayImage(); // loading necessary
            Console.WriteLine("Image1 calling DisplayImage second time :");
            Image1.DisplayImage(); // loading unnecessary
            Console.WriteLine("Image1 calling DisplayImage third time :");
            Image1.DisplayImage(); // loading unnecessary
            Console.WriteLine();
            IImage Image2 = new RealImageProxy("Lion Image");
            Console.WriteLine("Image2 calling DisplayImage first time :");
            Image2.DisplayImage(); // loading necessary
            Console.WriteLine("Image2 calling DisplayImage second time :");
            Image2.DisplayImage(); // loading unnecessary
            Console.ReadKey();
        }
    }
}

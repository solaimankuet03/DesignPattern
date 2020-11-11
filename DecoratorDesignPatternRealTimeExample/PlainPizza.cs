﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternRealTimeExample
{
    public class PlainPizza : IPizza
    {
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
}
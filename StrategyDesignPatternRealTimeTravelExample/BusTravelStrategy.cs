﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternRealTimeTravelExample
{
    public class BusTravelStrategy : ITravelStrategy
    {
        public void GoToAirport()
        {
            Console.WriteLine("Traveler is going to Airport by bus and will be charged Rs 300");
        }
    }
}

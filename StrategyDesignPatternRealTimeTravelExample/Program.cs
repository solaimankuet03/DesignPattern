﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternRealTimeTravelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Travel Type : Auto or Bus or Train or Taxi");
            string travelType = Console.ReadLine();
            Console.WriteLine("Travel type is : " + travelType);
            TravelContext ctx = null;
            ctx = new TravelContext();
            if ("Bus".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetStrategy(new BusTravelStrategy());
            }
            else if ("Train".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetStrategy(new TrainTravelStrategy());
            }
            else if ("Taxi".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetStrategy(new TaxiTravelStrategy());
            }
            else if ("Auto".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetStrategy(new AutoTravelStrategy());
            }
            ctx.gotoAirport();

            Console.Read();
        }
    }
}

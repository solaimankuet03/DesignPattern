using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternRealTimeTravelExample
{
    public class TaxiTravelStrategy : ITravelStrategy
    {
        public void GoToAirport()
        {
            Console.WriteLine("Traveler is going to Airport by Taxi and will be charged Rs 1000");
        }
    }
}

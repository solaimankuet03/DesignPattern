using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternRealTimeTravelExample
{
    public class TravelContext
    {
        private ITravelStrategy travelStrategy;

        public void SetStrategy(ITravelStrategy _travelStrategy)
        {
            travelStrategy = _travelStrategy;
        }

        public void gotoAirport()
        {
            travelStrategy.GoToAirport();
        }
    }
}

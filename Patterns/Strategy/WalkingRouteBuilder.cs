using System;

namespace Strategy
{
    public class WalkingRouteBuilder : IRouteBuilder
    {
        public void BuildRoute(Location begin, Location end)
        {
            Console.WriteLine($"By foot you can go from {begin} to {end}\nIn 1 hr 10 min");
        }
    }
}

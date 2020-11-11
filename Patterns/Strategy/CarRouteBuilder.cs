using System;

namespace Strategy
{
    public class CarRouteBuilder : IRouteBuilder
    {
        public void BuildRoute(Location begin, Location end)
        {
            Console.WriteLine($"By car you can go from {begin} to {end}\nIn 15 min");
        }
    }
}

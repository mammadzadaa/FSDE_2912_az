using System;

namespace Strategy
{
    public class PublicTransportRouteBuilder : IRouteBuilder
    {
        public void BuildRoute(Location begin, Location end)
        {
            Console.WriteLine($"By bus you can go from {begin} to {end}\nIn 40 min");
        }
    }
}

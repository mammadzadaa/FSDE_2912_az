namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(new PublicTransportRouteBuilder());
            map.BuilRoute(new Location(40.123m, 45.234m), new Location(43.234m, 46.456m));
            map.RoutBuilderStrategy = new WalkingRouteBuilder();
            map.BuilRoute(new Location(40.123m, 45.234m), new Location(43.234m, 46.456m));

        }
    }
}

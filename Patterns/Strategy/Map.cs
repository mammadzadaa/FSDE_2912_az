namespace Strategy
{
    public class Map
    {
        public IRouteBuilder RoutBuilderStrategy { get; set; }
        public Map(IRouteBuilder routeBuilderStrategy)
        {
            RoutBuilderStrategy = routeBuilderStrategy;
        }
        public void BuilRoute(Location begin, Location end)
        {
            RoutBuilderStrategy.BuildRoute(begin, end);
        }
    }
}

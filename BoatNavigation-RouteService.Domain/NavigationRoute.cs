namespace BoatNavigation_RouteService.Domain
{
    public class NavigationRoute
    {
        public Guid Id { get; }

        public List<NavigationRoutePoint> Points { get; set; }

        public NavigationRoute()
        {
            Id = Guid.NewGuid();
            Points = new List<NavigationRoutePoint>();
        }

        public NavigationRoute(Guid id)
        {
            Id = id;
            Points = new List<NavigationRoutePoint>();
        }
    }
}

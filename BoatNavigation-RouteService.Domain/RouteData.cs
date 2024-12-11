namespace BoatNavigation_RouteService.Domain
{
    public class RouteData
    {
        public Guid Id { get; }

        public List<RoutePoint> Points { get; set; }

        public RouteData()
        {
            Id = Guid.NewGuid();
            Points = new List<RoutePoint>();
        }

        public RouteData(Guid id)
        {
            Id = id;
            Points = new List<RoutePoint>();
        }
    }
}

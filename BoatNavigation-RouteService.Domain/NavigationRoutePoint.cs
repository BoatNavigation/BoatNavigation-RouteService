namespace BoatNavigation_RouteService.Domain
{
    public struct NavigationRoutePoint
    {
        public Guid Id { get; }

        public double Latitude { get; }

        public double Longitude { get; }

        public NavigationRoutePoint(Guid id, double latitude, double longitude)
        {
            Id = id;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}

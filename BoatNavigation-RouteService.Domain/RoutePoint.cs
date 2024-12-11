namespace BoatNavigation_RouteService.Domain
{
    public struct RoutePoint
    {
        public Guid Id { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}

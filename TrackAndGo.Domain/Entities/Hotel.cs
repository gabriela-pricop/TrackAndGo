namespace TrackAndGo.Domain.Entities
{
    public class Hotel : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public ICollection<PointOfInterestHotel> PointOfInterestHotels { get; set; } = [];
    }
}

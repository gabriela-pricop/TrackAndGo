namespace TrackAndGo.Domain.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int DistrictId { get; set; }
        public District District { get; set; }
        public List<Hotel> Hotels { get; set; }
        public ICollection<PointOfInterest> PointOfInterests { get; set; } = [];
    }
}

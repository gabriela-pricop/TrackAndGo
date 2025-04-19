namespace TrackAndGo.Domain.Entities
{
    public class PointOfInterest : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int InterestTypeId { get; set; } 
        public string ImageUrl { get; set; } = string.Empty;
        public string? WebsiteUrl { get; set; }
        public double Latitude { get; set; } 
        public double Longitude { get; set; }
        public string? Address { get; set; }
        public int CityId { get; set; }
        public  City City { get; set; } = new();
        public  ICollection<InterestImage> Images { get; set; } = [];
        public ICollection<PointOfInterestHotel> PointOfInterestHotels { get; set; } = [];
    }
}

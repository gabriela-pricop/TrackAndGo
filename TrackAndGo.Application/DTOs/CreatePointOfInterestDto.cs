namespace TrackAndGo.Application.DTOs
{
    public class CreatePointOfInterestDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Address { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string? WebsiteUrl { get; set; }
        public int InterestTypeId { get; set; }
        public int CityId { get; set; }
        public List<InterestImageDto> Images { get; set; } = [];
    }
}
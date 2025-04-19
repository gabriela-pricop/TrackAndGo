namespace TrackAndGo.Application.DTOs
{
    public class GetHotelDto
    {
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? FullAddress { get; set; }
    }
}

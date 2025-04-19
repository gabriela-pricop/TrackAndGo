using TrackAndGo.Shared.Enums;

namespace TrackAndGo.Application.DTOs
{
    public class PointsOfInterestDto 
    {
        public string ImageUrl { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public InterestTypeEnum Type { get; set; }
        public string FullAddress { get; set; } = string.Empty;
    }
}

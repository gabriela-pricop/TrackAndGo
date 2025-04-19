using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackAndGo.Shared.Enums;

namespace TrackAndGo.Application.DTOs
{
    public class GetPointOfInterestDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string? WebsiteUrl { get; set; }
        public InterestTypeEnum Type { get; set; }
        public string FullAddress { get; set; } = string.Empty;
        public List<InterestImageDto> Images { get; set; } = [];
    }
}

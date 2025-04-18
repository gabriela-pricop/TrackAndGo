﻿namespace TrackAndGo.Domain.Entities
{
    public class Hotel : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string? Address { get; set; }
        public ICollection<PointOfInterestHotel> PointOfInterestHotels { get; set; } = [];
    }
}

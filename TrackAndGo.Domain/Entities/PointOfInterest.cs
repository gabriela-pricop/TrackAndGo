using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackAndGo.Domain.Entities
{
    public class PointOfInterest : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int InterestTypeId { get; set; }//campul pentru LINQ care o sa salveze in baza
        public InterestType InterestType { get; set; } = new(); //navigational property
        public string ImageUrl { get; set; } = string.Empty;
        public string? WebsiteUrl { get; set; }//? - campul acesta poate sa lipseasca
        public double Latitude { get; set; } 
        public double Longitude { get; set; } 
        public int CityId { get; set; }
        public  City City { get; set; } = new(); //navigation property
        public  ICollection<InterestImage> Images { get; set; } = [];
        public ICollection<PointOfInterestHotel> PointOfInterestHotels { get; set; } = [];




    }
}

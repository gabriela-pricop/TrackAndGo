namespace TrackAndGo.Domain.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; } = string.Empty;//valoare default
        public int DistrictId { get; set; }
        public District District { get; set; }//navigational property, nu este camp
        //se adauga doar in disrectia legaturii
        public ICollection<PointOfInterest> PointOfInterests { get; set; } = [];
    }
}

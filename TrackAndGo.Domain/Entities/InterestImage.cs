namespace TrackAndGo.Domain.Entities
{
    public class InterestImage : BaseEntity
    {
        public string ImageUrl { get; set; } = string.Empty;
        public int PointOfInterestId {  get; set; }//for LINQ
        public PointOfInterest PointOfInterest { get; set; } = new();//navigational property
    }
}

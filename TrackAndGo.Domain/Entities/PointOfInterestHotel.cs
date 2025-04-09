namespace TrackAndGo.Domain.Entities
{
    public class PointOfInterestHotel : BaseEntity
    {
        //tabel de legatura 
        //multi la multi
        //avem nevoie de el din cauza la distance
        public int PointOfInterestId { get; set; }
        public PointOfInterest PointOfInterest { get; set; } = new();//navigational property
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = new(); // navigational property
        //distanta de la punctul turistic la hotel
        public int Distance {  get; set; } //dupa asta convertim in km, acum e in metri
    }
}

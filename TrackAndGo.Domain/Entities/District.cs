namespace TrackAndGo.Domain.Entities
{
    public class District : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<City> Cities { get; set; } = [];//navigation property, indican dca o sa aiba un list de city
    }
}

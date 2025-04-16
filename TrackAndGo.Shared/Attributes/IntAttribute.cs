namespace TrackAndGo.Shared.Attributes
{
    public class IntAttribute : Attribute
    {
        public IntAttribute(string id)
        {
            Value = Convert.ToInt32(id);
        }

        public int Value {  get; set; }
    }
}

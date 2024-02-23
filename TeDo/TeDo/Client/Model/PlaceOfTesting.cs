namespace TeDo.Client.Model
{
    public class PlaceOfTesting
    {
        public int Id { get; set; }
        public Firm? Firm { get; set; }
        public TestType Type { get; set; }
        public TestDocument? TestDocument { get; set; }
    }
}
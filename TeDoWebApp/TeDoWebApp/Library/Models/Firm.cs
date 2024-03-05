namespace Library.Models
{
    public class Firm
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FullAddress { get; set; }
        public List<Participant>? Participants { get; set; }
        public List<PlaceOfTesting>? PlacesOfTesting { get; set; }
    }
}
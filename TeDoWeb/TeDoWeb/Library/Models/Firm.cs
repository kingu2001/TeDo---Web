namespace TeDoWeb.Library.Models
{
    public class Firm
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FullAddress { get; set; }
        public bool SAT { get; set; }
        public bool IAT { get; set; }
        public bool OAT { get; set; }
        public bool FAT { get; set; }
        public List<Participant>? Participants { get; set; }
    }
}
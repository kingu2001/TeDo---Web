namespace TeDoWeb.Library.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Signature { get; set; }
        public string? Date { get; set; }
        public TestDocument? TestDocument { get; set; }
        public Firm? Firm { get; set; }
    }
}
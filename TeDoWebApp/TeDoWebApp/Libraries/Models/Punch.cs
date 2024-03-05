namespace TeDo.Libraries.Models
{
    public class Punch
    {
        public int Id { get; set; }
        public string? Test { get; set; }
        public int PunchNumber { get; set; }
        public string? Description { get; set; }
        public string? Owner { get; set; }
        public string? Action { get; set; }
        public TestDocument? TestDocument { get; set; }
    }
}
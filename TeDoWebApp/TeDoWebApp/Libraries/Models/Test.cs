namespace TeDo.Libraries.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Procedure { get; set; }
        public string? Description { get; set; }
        public string? IATInitials { get; set; }
        public string? SATInitials { get; set; }
        public string? FATInitials { get; set; }
        public string? OATInitials { get; set; }
        public TestDocument? TestDocument { get; set; }
    }
}
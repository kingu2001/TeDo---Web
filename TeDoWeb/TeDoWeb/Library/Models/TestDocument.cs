namespace TeDoWeb.Library.Models
{
    public class TestDocument
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Participant? Participant { get; set; }
        public string? Introduction { get; set; }
        public string? DocumentSupplied { get; set; }
        public List<DefinitionAndAbbreviation>? DefinitionAndAbbreviation { get; set; }
        public List<Firm>? Firms { get; set; }
        public List<Punch>? Punchlist { get; set; }
        public List<Revision>? Revisions { get; set; }

        public string Slug 
        { get
            {
                return Id.ToString();
            } 
        }

        public string FullUrl 
        { get
            {
                return string.Format("/testdocument/{0}", Id);
            } 
        }
    }
}

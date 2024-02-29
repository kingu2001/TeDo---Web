namespace TeDo.Client.Model
{
    public class TestDocument
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Participant? Participant { get; set; }
        public string? Introduction { get; set; }
        public string? DocumentSupplied { get; set; }
        public List<Punch>? Punchlist { get; set; }
        public List<PlaceOfTesting>? PlacesOfTesting { get; set; }
        public List<Revision>? Revisions { get; set; }
        public List<DefinitionAndAbbreviation>? DefinitionAndAbbreviation { get; set; }

    }
}
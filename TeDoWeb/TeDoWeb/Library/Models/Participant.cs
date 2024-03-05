﻿namespace TeDoWeb.Library.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Firm? Firm { get; set; }
        public string? Signature { get; set; }
        public DateOnly Date { get; set; }
        public TestDocument? TestDocument { get; set; }
    }
}
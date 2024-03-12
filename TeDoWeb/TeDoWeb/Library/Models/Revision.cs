﻿namespace TeDoWeb.Library.Models
{
    public class Revision
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string? PageAffected { get; set; }
        public string? ChapterAffected { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }
        public TestDocument? TestDocument { get; set; }
    }
}
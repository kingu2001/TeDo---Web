using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeDoWebApp.Libraries.Models
{
    public class DefinitionAndAbbreviation
    {
        public string? Definition { get; set; }
        public string? Abbreviation { get; set; }
        public TestDocument? TestDocument { get; set; }
    }
}

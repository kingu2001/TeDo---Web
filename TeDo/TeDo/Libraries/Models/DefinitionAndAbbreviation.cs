using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeDo.Libraries.Models;

namespace Libraries.Models
{
    public class DefinitionAndAbbreviation
    {
        public string? Definition { get; set; }
        public string? Abbreviation { get; set; }
        public TestDocument? TestDocument { get; set; }
    }
}

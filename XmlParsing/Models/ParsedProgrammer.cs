using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DomainModels;

namespace XmlParsing.Models
{
    [XmlRoot()]
    public class ParsedProgrammer
    {
        private readonly Programmer programmer;

        private ParsedProgrammer()
        {
            
        }

        public ParsedProgrammer(Programmer programmer)
        {
            if (programmer == null)
            {
                throw new ArgumentNullException("programmer");
            }

            this.programmer = programmer;
        }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}

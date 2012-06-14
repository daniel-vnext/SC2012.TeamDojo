using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using XmlParsing.Models;

namespace XmlParsing
{
    public class Network
    {
        [XmlElement("Programmer")]
        public List<ParsedProgrammer> Programmers { get; set; }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using DomainModels;
using NUnit.Framework;

namespace XmlParsing.Tests.AcceptanceTests
{
    [TestFixture]
    public class XmlParserShould
    {
        [Test]
        public void ParseASingleEmptyProgrammerFromAnXmlFile()
        {
            var filename = "AcceptanceTests\\SingleEmptyProgrammer.xml";
            var parser = new XmlParser(filename);

            IEnumerable<Programmer> programmer = parser.Parse();

            Assert.That(programmer.Single().Name, Is.EqualTo("Bill"));
        }
    }
}

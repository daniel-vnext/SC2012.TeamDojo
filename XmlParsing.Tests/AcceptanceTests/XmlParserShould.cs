using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
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

    public class XmlParser
    {
        private Network network;

        public XmlParser(string filename)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Network));
            network = serializer.Deserialize(new XmlTextReader(File.OpenRead(filename))) as Network;
        }

        public IEnumerable<Programmer> Parse()
        {
            var parsedProgrammers = network.Programmers;
            return parsedProgrammers.Select(parsedProgrammer => new Programmer(parsedProgrammer.Name));
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using NUnit.Framework;

namespace XmlParsing.Tests.UnitTests
{
    [TestFixture]
    public class DeserializeTests   
    {
        [Test]
        public void Foo()
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Network));
            var result = serializer.Deserialize(new XmlTextReader(File.OpenRead("AcceptanceTests\\SingleEmptyProgrammer.xml")));

            Assert.That(result, Is.InstanceOf<Network>());
            var network = result as Network;

            Assert.That(network.Programmers.Count, Is.EqualTo(1));
            Assert.That(network.Programmers.Single().Name, Is.EqualTo("Bill"));
        }

        [Test]
        public void Recommendations()
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Network));
            var result = serializer.Deserialize(new XmlTextReader(File.OpenRead("AcceptanceTests\\SingleProgrammerWithSingleRecommendation.xml")));
        }
    }
}

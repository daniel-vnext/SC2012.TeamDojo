using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModels;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    public class IncomingReccomandationEngineTests
    {
        [Test]
        public void JonnyHasNoRecommendations()
        {
            var jonny = new Programmer("Jonny");
            var jack = new Programmer("Jack");
            var matt = new Programmer("Matt");
            jonny.Recommendations.Add(jack);
            jonny.Recommendations.Add(matt);

            var network = new List<Programmer> {jonny, jack, matt};

            var engine = new IncomingReccomandationEngine();

            Dictionary<Programmer, int> incomingResults = engine.CalculateIncomingRecommendations(network);

            Assert.That(incomingResults[jonny], Is.EqualTo(0));
            Assert.That(incomingResults[jack], Is.EqualTo(1));
            Assert.That(incomingResults[matt], Is.EqualTo(1));
        }
    }
}

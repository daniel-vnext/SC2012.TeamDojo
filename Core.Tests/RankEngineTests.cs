using System.Collections.Generic;
using System.Linq;
using DomainModels;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    public class RankEngineTests
    {
        [Test, Ignore("work in progress")]
        public void CalculateRightRank()
        {
            var A = new Programmer("A");
            var B = new Programmer("B");
            var C = new Programmer("C");
            var D = new Programmer("D");
            B.Recommendations.Add(A);
            C.Recommendations.Add(A);
            A.Recommendations.Add(C);
            B.Recommendations.Add(C);
            D.Recommendations.Add(C);

            var network = new List<Programmer> { A,B,C,D };

            var rankEngine = new RankEngine();
            rankEngine.CalculateRank(network);
            Assert.That(network.Single(x=>x.Name=="D").Rank,Is.EqualTo(0.15));
        }
    }
}
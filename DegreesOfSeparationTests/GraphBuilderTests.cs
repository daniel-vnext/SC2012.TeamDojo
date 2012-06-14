using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainModels;
using DegreesOfSeparation;

namespace DegreesOfSeparationTests
{
    [TestClass]
    public class GraphBuilderTests
    {
        [TestMethod]
        public void builder_builds_expected_graph()
        {
            var a = new Programmer("Matt");
            var b = new Programmer("Marco");
            var c = new Programmer("Daniel");
            var d = new Programmer("Ben");

            a.Recommendations.Add(b);
            b.Recommendations.Add(c);
            
            b.Recommendations.Add(d);
            b.Recommendations.Add(a);
            b.Recommendations.Add(c);

            var subject = new GraphBuilder();
            var actual = subject.BuildGraph(new Programmer[] { a, b, c, d });

            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(LinkGraph));

            Assert.AreEqual(4, actual.NumberOfUniqueVertices);
            Assert.AreEqual(6, actual.Edges.Count());

            Assert.IsTrue(actual.Edges.Contains(new DirectedLink(a, b)));
            Assert.IsTrue(actual.Edges.Contains(new DirectedLink(b, a)));
            Assert.IsTrue(actual.Edges.Contains(new DirectedLink(b, c)));
            Assert.IsTrue(actual.Edges.Contains(new DirectedLink(c, b)));
            Assert.IsTrue(actual.Edges.Contains(new DirectedLink(b, d)));
            Assert.IsTrue(actual.Edges.Contains(new DirectedLink(d, b)));
        }
    }
}

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DegreesOfSeparation;
using DomainModels;

namespace DegreesOfSeparationTests
{
    [TestClass]
    public class SeparationFinderTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void finder_throws_exception_passed_null_graph()
        {
            var subject = new SeparationFinder();

            Programmer a = new Programmer("Matt");

            var actual = subject.FindDegreesBetween(null, a, a);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void finder_throws_exception_passed_null_from()
        {
            var subject = new SeparationFinder();

            Programmer a = new Programmer("Matt");
            Programmer b = new Programmer("Marco");

            var graphBuilder = new GraphBuilder();
            var graph = graphBuilder.BuildGraph(new Programmer[] { a, b });

            var actual = subject.FindDegreesBetween(graph, null, b);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void finder_throws_exception_passed_null_to()
        {
            var subject = new SeparationFinder();

            Programmer a = new Programmer("Matt");
            Programmer b = new Programmer("Marco");

            var graphBuilder = new GraphBuilder();
            var graph = graphBuilder.BuildGraph(new Programmer[] { a, b });

            var actual = subject.FindDegreesBetween(graph, a, null);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void finder_finds_separation_between_two_distinct_nodes()
        {
            var subject = new SeparationFinder();

            // setup some likely links
            var a = new Programmer("Matt");
            var b = new Programmer("Adrian");
            var c = new Programmer("Ben");
            var d = new Programmer("Marco");

            a.Recommendations.Add(b);
            b.Recommendations.Add(c);
            c.Recommendations.Add(d);

            var theGraph = new GraphBuilder().BuildGraph(new Programmer[] { a, b, c, d });

            var theFinder = new SeparationFinder();
            var actual = theFinder.FindDegreesBetween(theGraph, a, d);

            Assert.AreEqual(3, actual);
        }
    }
}

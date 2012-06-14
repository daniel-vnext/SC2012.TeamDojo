using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeCoreObjects;
using DegreesOfSeparation;

namespace DegreesOfSeparationTests
{
    [TestClass]
    public class FinderTests
    {

        [TestMethod]
        public void finder_returns_zero_degrees_between_self()
        {
            var subject = new Finder();

            Programmer a = new Programmer();

            var actual = subject.FindDegreesBetween(a, a);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void finder_finds_separation_between_two_distinct_nodes()
        {
            Programmer a = new Programmer();
            Programmer b = new Programmer();

            a.Recommends.Add(b);

            

        }
    }
}

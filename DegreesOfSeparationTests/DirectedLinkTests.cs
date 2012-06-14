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
    public class DirectedLinkTests
    {
        [TestMethod]
        public void directed_link_asserts_equality()
        {
            Programmer a = new Programmer("Matt");
            Programmer b = new Programmer("Mike");

            DirectedLink x = new DirectedLink(a, b);
            DirectedLink y = new DirectedLink(a, b);

            Assert.AreEqual(x, y);
            Assert.AreNotSame(x, y);

            Programmer c = new Programmer("Marco");
            DirectedLink z = new DirectedLink(a, c);

            Assert.AreNotEqual(x, z);
        }
    }
}

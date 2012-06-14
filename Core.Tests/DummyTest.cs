using System;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    public class DummyTest
    {
        [Test]
        public void TeamCity_should_run_this_test()
        {
            Console.WriteLine("Hi, this line should appear in the TC logs! :)");
        }
    }
}
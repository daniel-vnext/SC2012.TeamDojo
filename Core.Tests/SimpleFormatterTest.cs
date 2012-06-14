using System.Collections.Generic;
using DomainModels;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    public sealed class SimpleFormatterTest
    {
        [Test]
        public void TestThat_diplays_header_given_empty_list_of_developers()
        {
            var simpleFormatter = new SimpleFormatter();
            var report = simpleFormatter.Format(new List<Programmer>());

            Assert.AreEqual(SimpleFormatter.header, report);
        }
        
        [Test]
        public void TestThat_diplays_a_single_programmer()
        {
            var simpleFormatter = new SimpleFormatter();

            var adrian = new Programmer("Adrian");
            var programmer = new Programmer("Ben");
            programmer.Skills.Add(Skills.CSharp);
            programmer.Recommendations.Add(adrian);
            var report = simpleFormatter.Format(new[] {programmer});

            StringAssert.Contains("Ben", report);
            StringAssert.Contains("CSharp", report);
            StringAssert.Contains("Adrian", report);
        }
    }
}

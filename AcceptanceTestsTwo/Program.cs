using System;
using System.Collections.Generic;
using Core;
using DomainModels;

namespace AcceptanceTestsTwo
{
    class Program
    {
        static void Main()
        {
            var formatter = new KudosFormatter();

            var report = formatter.Format(Case1());
            Console.WriteLine(report);
            report = formatter.Format(Case2());
            Console.WriteLine(report);

            Console.ReadLine();
        }

        private static IEnumerable<Programmer> Case1()
        {
            var a = new Programmer("A");
            var b = new Programmer("B");

            a.Recommendations.Add(b);
            b.Recommendations.Add(a);

            return new[] {a, b};
        }

        private static IEnumerable<Programmer> Case2()
        {
            var a = new Programmer("A");
            var b = new Programmer("B");
            var c = new Programmer("C");
            var d = new Programmer("D");
            
            a.Recommendations.Add(b);
            a.Recommendations.Add(c);
            
            b.Recommendations.Add(c);

            c.Recommendations.Add(a);
            
            d.Recommendations.Add(c);

            return new[] {a, b, c, d};
        }
    }
}

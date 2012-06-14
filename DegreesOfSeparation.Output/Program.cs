using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModels;
using DegreesOfSeparation;

namespace DegreesOfSeparation.Output
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new SeparationFinder();

            var a = new Programmer("Matt");
            var b = new Programmer("Adrian");
            var c = new Programmer("Ben");
            var d = new Programmer("Marco");

            a.Recommendations.Add(b);
            b.Recommendations.Add(c);
            c.Recommendations.Add(d);

            var programmers = new Programmer[] { a, b, c, d };
            var theGraph = new GraphBuilder().BuildGraph(programmers);

            SeparationRenderer renderer = new SeparationRenderer();
            renderer.Render(Console.Out, theGraph);

            Console.ReadLine();
        }
    }
}

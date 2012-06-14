using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DegreesOfSeparation.Output
{
    public class SeparationRenderer
    {

        public SeparationRenderer()
        {
        }

        public void Render(TextWriter outStream, LinkGraph graph)
        {
            var separationFinder = new SeparationFinder();

            outStream.Write("{0,-10}", "");
            foreach (var programmer in graph.Vertices)
            {
                outStream.Write("{0,-10}", programmer.Name);
            }

            outStream.WriteLine();

            foreach (var y in graph.Vertices)
            {
                outStream.Write("{0,-10}", y.Name);
                foreach (var x in graph.Vertices)
                {
                    outStream.Write("{0,-10}", separationFinder.FindDegreesBetween(graph, y, x));
                }
                outStream.WriteLine();
            }
        }
    }
}

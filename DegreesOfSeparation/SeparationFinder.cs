using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModels;
using GraphLibrary;

namespace DegreesOfSeparation
{
    public class SeparationFinder
    {
        public int FindDegreesBetween(LinkGraph graph, Programmer a, Programmer b)
        {
            if (a == null)
                throw new ArgumentNullException("a");

            if (b == null)
                throw new ArgumentNullException("b");

            if (graph == null)
                throw new ArgumentNullException("graph");

            if (a.Equals(b))
                return 0;

            var algo = new KShortestPathAlgorithm();

            var result = algo.FindShortestPaths<DirectedLink, Programmer>(graph, a, b, 1);

            // if the algorithmn has returned no routes
            // return 0
            if (result.Count() == 0) return 0;

            // otherwise return the number of edges in the
            // quickest route.
            return result.ElementAt(0).Count();
        }

    }
}

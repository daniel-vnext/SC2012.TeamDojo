using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphLibrary;
using DomainModels;

namespace DegreesOfSeparation
{
    public class LinkGraph : Graph<DirectedLink, Programmer>
    {

        public LinkGraph(IEnumerable<DirectedLink> edges)
            : base(edges)
        {
        }

    }
}

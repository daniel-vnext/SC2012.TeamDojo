using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModels;

namespace DegreesOfSeparation
{
    public class GraphBuilder
    {

        public LinkGraph BuildGraph(IEnumerable<Programmer> programmers)
        {
            var links = new HashSet<DirectedLink>();

            foreach ( var p in programmers ) 
            {
                foreach ( var l in p.Recommendations ) 
                {
                    var fromLink = new DirectedLink ( p, l );
                    var toLink = new DirectedLink ( l, p );

                    if ( !links.Contains ( fromLink ) )
                        links.Add ( fromLink );

                    if ( ! links.Contains(toLink))
                        links.Add ( toLink );
                }
            }

            return new LinkGraph(links);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphLibrary;
using DomainModels;

namespace DegreesOfSeparation
{
    public class DirectedLink : IEdge<Programmer>
    {
        public DirectedLink(Programmer head, Programmer tail)
        {
            if (head == null)
                throw new ArgumentNullException("head");

            if (tail == null)
                throw new ArgumentNullException("tail");

            this.Head = head;
            this.Tail = tail;
        }

        public Programmer Head
        {
            get;
            private set;
        }

        public Programmer Tail
        {
            get;
            private set;
        }

        public int Weight
        {
            get { return 1; }
        }

        public override int GetHashCode()
        {
            return String.Format("{0}>{1}", Head.Name, Tail.Name).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            DirectedLink that = obj as DirectedLink;
            if (that == null)
                return false;

            return this.Tail.Equals(that.Tail) &&
                this.Head.Equals(that.Head);
        }

    }
}

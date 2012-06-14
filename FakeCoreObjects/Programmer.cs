using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakeCoreObjects
{
    public class Programmer
    {

        public Programmer() 
        {
        }

        public string Name { get; set; }

        public IList<Programmer> Recommends
        {
            get;
            private set;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Programmer that = obj as Programmer;
            if (that == null) return false;

            return this.GetHashCode().Equals(that.GetHashCode());
        }

    }
}

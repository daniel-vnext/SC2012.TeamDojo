using System;
using System.Collections.Generic;

namespace DomainModels
{
    public class Programmer
    {
        public decimal Rank { get; set; }
        public string Name { get; private set; }
        public ICollection<Programmer> Recommendations { get; private set; }
        public ICollection<Skills> Skills { get; private set; }

        public Programmer(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name");
            }

            Name = name;
            Recommendations = new List<Programmer>();
            Skills = new List<Skills>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;

namespace AcceptanceTestOne
{
    class Program
    {
        static void Main()
        {
            //TODO: replace this test data with the real data
            var ben = new Programmer("Ben");
            ben.Skills.Add(Skills.CSharp);
            ben.Skills.Add(Skills.Java);
            var adrian = new Programmer("Adrian");
            adrian.Skills.Add(Skills.CSharp);
            adrian.Skills.Add(Skills.Ruby);

            ben.Recommendations.Add(adrian);

            var programmers = new List<Programmer>()
                                  {
                                              adrian,
                                              ben
                                  };

            foreach (var programmer in programmers.OrderBy(p => p.Name))
            {
                var skills = string.Join(", ", programmer.Skills);
                var recommendations = string.Join(", ", programmer.Recommendations.Select(p => p.Name));
                Console.WriteLine("{0,-20}{1,-20}{2,-20}", programmer.Name, skills, recommendations);
            }

            Console.ReadLine();
        }
    }
}

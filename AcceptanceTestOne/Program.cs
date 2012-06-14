using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
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

            var formatter = new SimpleFormatter();
            var report = formatter.Format(programmers);

            Console.Write(report);

            Console.ReadLine();
        }
    }
}

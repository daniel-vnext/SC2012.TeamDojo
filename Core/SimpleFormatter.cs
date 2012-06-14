using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModels;

namespace Core
{
    public class SimpleFormatter
    {
        public const string header = 
@"Programmer          Skills              Recommends
----------          ------              ----------\r\n";
            

        public string Format(IEnumerable<Programmer> programmers)
        {
            var report = new StringBuilder();

            report.Append(header);

            foreach (var programmer in programmers.OrderBy(p => p.Name))
            {
                var skills = string.Join(", ", programmer.Skills);
                var recommendations = string.Join(", ", programmer.Recommendations.Select(p => p.Name));
                report.AppendFormat("{0,-20}{1,-20}{2,-20}{3}", programmer.Name, skills, recommendations, Environment.NewLine);
            }

            return report.ToString();
        }
    }
}

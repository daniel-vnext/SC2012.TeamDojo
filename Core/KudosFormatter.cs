using System.Collections.Generic;
using System.Linq;
using DomainModels;

namespace Core
{
    public class KudosFormatter
    {
        public string Format(IEnumerable<Programmer> programmers)
        {
            var ordered = programmers.OrderBy(p => p.Rank);
            return string.Join(", ", ordered.Select(p => string.Format("{0}={1}", p.Name, p.Rank)));
        }
    }
}
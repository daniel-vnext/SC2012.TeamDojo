using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModels;

namespace Core
{
    public class IncomingReccomandationEngine
    {
        
        public Dictionary<Programmer,int> CalculateIncomingRecommendations(List<Programmer> network)
        {
            Dictionary<Programmer,int> incomingRecommentations = InitializeResults(network);
            foreach(var programmer in network)
            {
                AddIncomingRecommendations(incomingRecommentations,programmer.Recommendations);
            }
            return incomingRecommentations;
        }

        private void AddIncomingRecommendations(Dictionary<Programmer, int> incomingRecommentations, IEnumerable<Programmer> recommendations)
        {
            foreach (var recommendation in recommendations)
            {
                incomingRecommentations[recommendation]++;
            }
        }

        private Dictionary<Programmer,int> InitializeResults(IEnumerable<Programmer> network)
        {
            return network.ToDictionary(programmer => programmer, programmer => 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.PatternMatching
{
    public class LogicalPatterns
    {
        public string GetWeatherAdvice(string weather, bool isRaining)
        {
            string advice = (weather, isRaining) switch
            {
                ("Sunny", false) => "Enjoy the sunshine!",
                ("Rainy", true) => "Remember your umbrella!",
                (_, _) => "Check the weather forecast."
            };
            return advice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.SwitchCase
{
    public class Test
    {
        public string GetExperienceLevelCSharp9(int exp)
        {
            string result = exp switch
            {
                0 => "Fresher",
                > 0 and <= 2 => "Beginner",
                > 2 and <= 5 => "Intermediate",
                _ => "Expert"
            };
            return result;
        }
    }
}

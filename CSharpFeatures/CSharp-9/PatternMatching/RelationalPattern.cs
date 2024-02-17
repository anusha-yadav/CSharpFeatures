using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.PatternMatching
{
    public class RelationalPattern
    {
        public string EvaluateGrade(int score)
        {
            string grade = score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };
            return grade;
        }

        public string Evaluate(int score)
        {
            string grade;
            if (score >= 90)
            {
                grade = "A";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70)
            {
                grade = "C";
            }
            else if (score >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            return grade;
        }

    }
}

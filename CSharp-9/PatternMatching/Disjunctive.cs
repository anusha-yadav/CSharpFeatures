using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.PatternMatching
{
    public class Disjunctive
    {
        object shape = new Circle { Radius = 100 };

        public void IsBigCircleValue(object shape)
        {
            if(shape is Circle { Radius: 100 or 200 })
            {
                Console.WriteLine("This is a big Circle");
            }
        }
    }
}

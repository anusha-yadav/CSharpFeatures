using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.PatternMatching
{
    /// <summary>
    /// It can be used for comparisons by testing how a value compares
    /// to a constant using comparison operators (<,>,>=,<=)
    /// </summary>
    public class RelationalPattern
    {
        object shape = new Circle { Radius = 110 };

        public void IsBigCircle(object shape)
        {
            if(shape is Circle { Radius: >= 100 })
            {
                Console.WriteLine($"This is a big Circle");
            }
        }
    }
}

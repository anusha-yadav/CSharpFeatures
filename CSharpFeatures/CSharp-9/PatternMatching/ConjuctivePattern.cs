using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.PatternMatching
{
    public class ConjuctivePattern
    {
        object shape = new Circle { Radius = 110 };

        public void IsBigCircle(object shape)
        {
            if(shape is Circle { Radius: >= 100 and <= 200 })
            {
                Console.WriteLine($"This a big Circle");
            }
        }
    }
}

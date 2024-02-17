using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.PatternMatching
{
    public class TypePattern
    {
        object shape = new Square { Length = 5 };

        public void IsShapeSquare(object shape)
        {
            if(shape is Square)
            {
                Console.WriteLine($"{shape} is a square");
            }
            else
            {
                Console.WriteLine($"{shape} is not a square");
            }
        }
    }
}

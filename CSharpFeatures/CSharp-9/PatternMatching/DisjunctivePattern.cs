using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.PatternMatching
{
    public class DisjunctivePattern
    {
        Shape shape = new Circle { Radius = 100 };
        public void IsBigCircleValue(Shape shape)
        {
            if (shape is Circle { Radius: 100 or 200 })
            {
                Console.WriteLine("This is a big Circle");
            }
        }

        public void IsBigCircle(Shape shape)
        {
            if(shape.GetType() == typeof(Circle))
            {
                Circle circle = (Circle) shape;
                if(circle.Radius == 100 || circle.Radius == 200)
                {
                    Console.WriteLine("This is a big circle");
                }
            }
        }
    }
}

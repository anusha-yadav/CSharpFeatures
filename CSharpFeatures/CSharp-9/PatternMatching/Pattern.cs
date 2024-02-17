using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.PatternMatching
{
    public class Shape
    {
        public int Sides { get; set; }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
    }

    public class Square : Shape
    {
        public double SideLength { get; set; }
    }  
}

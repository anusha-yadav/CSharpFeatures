using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.PatternMatching
{
    public class TypePattern
    {
        public string GetShapeInfo(Shape shape)
        {
            string info = shape switch
            {
                Circle circle when circle.Radius > 0 => $"Circle with radius {circle.Radius}",
                Square square when square.SideLength > 0 => $"Square with side length {square.SideLength}",
                _ => "Unknown shape"
            };
            return info;
        }

        // Before versions
        public string GetShape(Shape shape)
        {
            string info;
            if (shape is Circle circle && circle.Radius > 0)
            {
                info = $"Circle with radius {circle.Radius}";
            }
            else if (shape is Square square && square.SideLength > 0)
            {
                info = $"Square with side length {square.SideLength}";
            }
            else
            {
                info = "Unknown shape";
            }
            return info;
        }

    }
}

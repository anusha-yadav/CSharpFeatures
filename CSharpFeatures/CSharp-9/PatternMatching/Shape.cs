using System;

namespace CSharp_9.PatternMatching
{
    public class Shape
    {
        public double CalculateArea(object shape)
        {
            return shape switch
            {
                null => throw new ArgumentException(nameof(shape)),

                Square { Length: var l } => l * l,
                Rectangle { length: var l, width: var w } => l * w,
                Circle { Radius: var r } => r * r * Math.PI,
                _ => throw new NotImplementedException()
            }; 
        }
    }
}

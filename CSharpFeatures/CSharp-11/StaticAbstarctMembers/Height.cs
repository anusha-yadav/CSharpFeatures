using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_11.StaticAbstarctMembers
{
    public record struct Height(double Val) : IMeasuarable<Height>
    {
        public static Height One => new(1);
        public static Height Zero => new(0);
        public static Height operator +(Height a, Height b)
        {
            return new Height(a.Val + b.Val);
        }

        public static Height operator /(Height a, Height b)
        {
            return new Height(a.Val / b.Val);
        }
    }
}

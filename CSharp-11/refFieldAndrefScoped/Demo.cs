using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_11.refFieldAndrefScoped
{
    public class Demo
    {
        readonly ref struct Span<T>
        {
            private readonly ref T _field;
            private readonly int _length;

            public Span(ref T value)
            {
                _field = ref value;
                _length = 1;
            }
        }

        public ref struct RefFieldExample
        {
            private ref int number;
            public int GetNumber()
            {
                if(System.Runtime.CompilerServices.Unsafe.IsNullRef(ref number))
                {
                    throw new InvalidOperationException("The number ref field is not initialized");
                }
                return number;
            }
        }
    }
}

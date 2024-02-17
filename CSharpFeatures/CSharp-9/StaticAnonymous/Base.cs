using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.StaticAnonymous
{
    [MemoryDiagnoser]
    public class Base
    {
        private readonly int _numNonConst = 10;
        private const int _numConst = 10;

        private readonly double _numberInEnclosingScope = 4;
        private static double _numberInEnclosingScopeConst = 5;

        void CalculatePower(Func<double, double> func)
        {
            Console.WriteLine(func(6));
        }

        public void Display()
        {
            CalculatePower(static num => Math.Pow(_numberInEnclosingScopeConst, num));
        }

        public int Calculate(Func<int, int> func)
        {
            return func(6);
        }

        [Benchmark]
        public int MultiplyNonStatic()
        {
            return Calculate(num => _numNonConst * num);
        }

        [Benchmark]
        public int MultiplyNonStaticWithConst()
        {
            return Calculate(num => _numConst * num);
        }

        [Benchmark]
        public int MultiplyStatic()
        {
            return Calculate(static num => _numConst * num);
        }
    }
}

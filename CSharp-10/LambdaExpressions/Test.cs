using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_10.LambdaExpressions
{
    public class Test
    {
        public Action<string> greet = name =>
        {
            string greeting = $"Hello {name}";
            Console.WriteLine(greeting);
        };

        public Func<double, double> cube = x => x * x * x;

        public Func<int, int, bool> testForEquality = (x, y) => x == y;

        public Func<int, int, int> constant = (_, _) => 42;

    }
}

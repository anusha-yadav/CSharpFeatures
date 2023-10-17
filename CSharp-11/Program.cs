using CSharp_11.ListPatterns;
using CSharp_11.StaticAbstarctMembers;
using static CSharp_11.ListPatterns.Test;

namespace CSharp_11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Height heightAverage = Average(new Height(1.5), new Height(2), new Height(3), new Height(4));
            Console.WriteLine(heightAverage.Val);

            Console.WriteLine("*****************");

            Class1 obj1 = new();
            Class2 obj2 = new();
            Class1 obj3 = obj2;

            // Static abstract cannot be made virtual
            Demo demo = new Demo();
            demo.ConsoleWriteLine(obj1);
            demo.ConsoleWriteLine(obj2);
            demo.ConsoleWriteLine(obj3);

            Console.WriteLine("****************************");

            // List Patterns
            // The list pattern is to check, if sequence elements match corresponding nested patterns.
            Test test = new();
            test.Pattern();
            test.Deconstruction();

            var emptyArray = Array.Empty<string>();
            var myName = new[] { "David Warner" };
            var myNameFields = new[] { "David", "Warner" };
            var myNameMiddleFields = new[] { "David", "Abraham", "Warner" };

            test.SwitchStatement(emptyArray);
            test.SwitchStatement(myName);
            test.SwitchStatement(myNameMiddleFields);
            test.SwitchStatement(myNameFields);

        }

        private static T Average<T>(params T[] array) where T : IMeasuarable<T>
        {
            if (array.Length == 0)
            {
                return T.Zero;
            }
            T result = T.Zero;
            T denominator = T.Zero;
            foreach (T val in array)
            {
                result += val;
                denominator += T.One;
            }
            return result / denominator;
        }
    }

    
}
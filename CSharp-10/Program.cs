using System;
using CSharp_10.LambdaExpressions;

class Demo
{
    public static void Main()
    {
        Test test = new();
        test.greet("World");
        Console.WriteLine(test.cube(4));
        Console.WriteLine(test.testForEquality(4, 5));
        Console.WriteLine(test.constant(2, 3));


        var sum = (params int[] val) =>
        {
            int sum = 0;
            foreach (int i in val)
            {
                sum += i;
            }
            return sum;
        };

        var empty = sum();
        Console.WriteLine(empty);

        var sequence = new[] { 1, 2, 3, 4 };
        var total = sum(sequence);
        Console.WriteLine(total);

        // In C#12 default values for parameters on lambda expressions
        var IncrementBy = (int source, int increment = 1) => source + increment;
        Console.WriteLine(IncrementBy(5)); 
        Console.WriteLine(IncrementBy(5, 2)); 
    }
}

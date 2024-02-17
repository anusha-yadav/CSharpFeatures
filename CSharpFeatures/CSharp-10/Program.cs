using System;
using System.Collections.Generic;
using System.Diagnostics;
using CSharp_10.LambdaExpressions;

class Demo
{
    public static void Main()
    {
        //Lambda Expressions
        Test test = new();
        test.greet("World");
        Console.WriteLine(test.cube(4));
        Console.WriteLine(test.testForEquality(4, 5));
        Console.WriteLine(test.constant(2, 3));
        var lambda = [DebuggerStepThrough] () => "Hello World";
        string text = lambda();
        Console.WriteLine(text);
        // inferred type is Func<int[]>
        var oneTwoThreeArray = () => new[] { 1, 2, 3 }; 
        int[] resultantArray = oneTwoThreeArray();

        for(int i=0;i<resultantArray.Length; i++)
        {
            Console.Write(resultantArray[i]+ " ");
        }
        Console.WriteLine();
        // same body, but inferred type is now Func<IList<int>
        var oneTwoThreeList = IList<int> () => new[] { 5, 2, 3 }; 
        IList<int>resultant = oneTwoThreeList();

        for(int i=0;i<resultant.Count;i++)
        {
            Console.Write(resultant[i] + " ");
        }
        Console.WriteLine();
        Func<int, bool> isEven = (int n) => n % 2 == 0;
        isEven (4);
        // isEven is implicitly of type Func<int, bool>
        var is_Even = (int n) => n % 2 == 0;
        is_Even (5);
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

        /*var oneTwoThreeList = new[] { 1, 2, 3, 4 };
        var total = sum(oneTwoThreeList);
        Console.WriteLine(total);*/

        // In C#12 default values for parameters on lambda expressions
        var IncrementBy = (int source, int increment = 1) => source + increment;
        Console.WriteLine(IncrementBy(5)); 
        Console.WriteLine(IncrementBy(5, 2)); 
    }
}

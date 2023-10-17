using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_11.ListPatterns
{
    public class Test
    {
        public void Pattern()
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers is [1, 2, 3]);
            Console.WriteLine(numbers is [1 ,2, 4]);
            Console.WriteLine(numbers is [1,2,3,4]);
            Console.WriteLine(numbers is [0 or 1, <=2, >=1]);
        }

        public void Deconstruction()
        {
            int[] numbers = { 1, 2, 3, 4 };
            if(numbers is [var first,_,.. var others])
            {
                Console.WriteLine(first);
                Console.WriteLine(string.Join(",",others.Select(x=>x.ToString())));
            }
        }

        public void SwitchStatement(string[] items)
        {
            var text = items switch
            {
                [] => "Name was empty",
                [var fullName] => $"My name is {fullName}",
                [var firstName, var secondName] => $"My name is {firstName} {secondName}",
                _ => "Didnot match"
            } ;
            Console.WriteLine(text);
        } 
    }
}

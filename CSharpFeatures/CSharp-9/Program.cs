using CSharp_9.CovariantReturnType;
using CSharp_9.PatternMatching;
using CSharp_9.StaticAnonymous;
using CSharp_9.SwitchCase;
using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace CSharp_9
{
    public class Program
    {
        public static void Main()
        {
/*          Test test = new();
            string result = test.GetExperienceLevelCSharp9(4);
            Console.WriteLine(result);
*/
            Shape shape = new Shape();
            Circle circle = new() { Radius = 10 };
            Console.WriteLine(shape.CalculateArea(circle));

            //Static Anonymous
            //To avoid unnecessary and wasteful memory allocation,
            //we can use the static keyword on the lambda and the
            //const keyword on the variable or object that we do
            //not want to be captured.
            new Base().Display();
            Console.Read();

            //CovariantReturnType
            Book book = new Book("My Book", 1, "123-567-7890");
            BookOrder orderBook = book.Order(2);
            Music music = new Music("My Music", 2, Format.Mp3);
            MusicOrder orderMusic = music.Order(2);
        }
    }
}
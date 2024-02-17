using CSharp_9.CovariantReturnType;
using System;
using System.Runtime.CompilerServices;

namespace CSharp_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Covariant Return type
            Book book = new Book("My Book", 1, "123-567-7890");
            BookOrder orderBook = (BookOrder)book.Order(2);
            Music music = new Music("My Music", 2, Format.Mp3);
            MusicOrder orderMusic = (MusicOrder)music.Order(2);

            //Switch Case 
            var choice = 3;
            var res = choice switch
            {
                0 => "Fresher",
                var x when (x>=1 && x<=2) => "Beginner",
                var x when (x<5) => "Intermediate",
                _ => "Experienced",
            };
            Console.WriteLine(res);

            var option = 7;
            string result;

            switch (option)
            {
                case 0:
                    result = "Fresher";
                    break;
                case var x when (x >= 1 && x <= 2):
                    result = "Beginner";
                    break;
                case var x when (x < 5):
                    result = "Intermediate";
                    break;
                default:
                    result = "Experienced";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
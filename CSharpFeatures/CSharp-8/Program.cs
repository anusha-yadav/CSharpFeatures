using CSharp_9.CovariantReturnType;
using System;

namespace CSharp_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("My Book", 1, "123-567-7890");
            BookOrder orderBook = (BookOrder)book.Order(2);
            Music music = new Music("My Music", 2, Format.Mp3);
            MusicOrder orderMusic = (MusicOrder)music.Order(2);
        }
    }
}
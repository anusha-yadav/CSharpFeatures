using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    public class Test
    {
        public static async void LongProcess()
        {
            Console.WriteLine("LongProcess Started");
            await Task.Delay(4000);
            Console.WriteLine("LongProcess Completed");
        }

        public static async void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");
            Console.WriteLine("ShortProcess Completed");
        }

        public static async Task Base()
        {
            Console.WriteLine("1. Base method");
            string file = await File.ReadAllTextAsync("notes.txt");
            Console.WriteLine("2. Base method");
        }
    }
}

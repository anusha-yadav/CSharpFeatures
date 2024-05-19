using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    public class Program
    {
        static async Task<string> DoTaskAsync(string name, int timeout)
        {
            var start = DateTime.Now;
            Console.WriteLine("Enter {0}, {1}", name, timeout);
            await Task.Delay(timeout);
            Console.WriteLine("Exit {0}, {1}", name, (DateTime.Now - start).TotalMilliseconds);
            return name;
        }

        static async Task DoWork1()
        {
            var t1 = DoTaskAsync("t1.1", 3000);
            var t2 = DoTaskAsync("t1.2", 2000);
            var t3 = DoTaskAsync("t1.3", 1000);

            await t1; await t2; await t3;

            Console.WriteLine("DoWork1 results: {0}", String.Join(", ", t1.Result, t2.Result, t3.Result));
        }

        /*
         * The primary difference between the await and Task.whenall is that Task.whenAll will complete all the
         * tasks and will return the task. Whereas, await will wait 
         */
        static async Task DoWork2()
        {
            var t1 = DoTaskAsync("t2.1", 3000);
            var t2 = DoTaskAsync("t2.2", 2000);
            var t3 = DoTaskAsync("t2.3", 1000);

            await Task.WhenAll(t1, t2, t3);

            Console.WriteLine("DoWork2 results: {0}", String.Join(", ", t1.Result, t2.Result, t3.Result));
        }

        public static async Task Main(string[] args)
        {
            //Test.LongProcess();
            //Test.ShortProcess();
            //Test.Base();
            //Task.WhenAll(DoWork1(), DoWork2()).Wait();
            //DoSynchronousWork();
            //var someTask = DoSomethingAsync();
            //DoSynchronousWorkAfterAwait();
            //someTask.Wait(); //this is a blocking call, use it only on Main method
            //Console.ReadLine();
            var t1 = Task.Run(() => DoWork(1, 1000));
            var t2 = Task.Run(() => DoWork(2, 500));
            Task<int> completedTask = await Task.WhenAny(t1, t2);
            int result = await completedTask;
            Console.WriteLine(result);
        }

        private const string URL = "https://docs.microsoft.com/en-us/dotnet/csharp/csharp";
        public static void DoSynchronousWork()
        {
            // You can do whatever work is needed here
            Console.WriteLine("1. Doing some work synchronously");
        }

        static async Task DoSomethingAsync() //A Task return type will eventually yield a void
        {
            Console.WriteLine("2. Async task has started...");
            await GetStringAsync(); // we are awaiting the Async Method GetStringAsync
        }

        static async Task GetStringAsync()
        {
            using (var httpClient = new HttpClient())
            {
                Console.WriteLine("3. Awaiting the result of GetStringAsync of Http Client...");
                string result = await httpClient.GetStringAsync(URL); //execution pauses here while awaiting GetStringAsync to complete

                //From this line and below, the execution will resume once the above awaitable is done
                //using await keyword, it will do the magic of unwrapping the Task<string> into string (result variable)
                Console.WriteLine("4. The awaited task has completed. Let's get the content length...");
                Console.WriteLine($"5. The length of http Get for {URL}");
                Console.WriteLine($"6. {result.Length} character");
            }
        }

        static void DoSynchronousWorkAfterAwait()
        {
            //This is the work we can do while waiting for the awaited Async Task to complete
            Console.WriteLine("7. While waiting for the async task to finish, we can do some unrelated work...");
            for (var i = 0; i <= 5; i++)
            {
                for (var j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        static async Task<int> DoWork(int number, int ms)
        {
            await Task.Delay(ms);
            return number;
        }
    }
}

using System;
using System.Threading.Tasks;

namespace AsyncAwaitLearn
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await PrintGreetingAsync();
        }

        public static async Task PrintGreetingAsync()
        {
            await Task.Delay(50);
            await Console.Out.WriteLineAsync("Hello from async master!");
            await Console.Out.WriteLineAsync("Learning Async/Await step by step");
        }
    }
}

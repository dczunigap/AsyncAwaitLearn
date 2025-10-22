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
            var greetings = new[]
            {
                "Hello from async master!",
                "Learning Async/Await step by step",
                "Master branch keeps async greetings fresh"
            };

            foreach (var greeting in greetings)
            {
                await Console.Out.WriteLineAsync(greeting);
                await Task.Delay(50);
            }
        }
    }
}

using System;
using System.IO;
using System.Threading.Tasks;
using AsyncAwaitLearn;
using Xunit;

namespace AsyncAwaitLearn.Tests
{
    public class ProgramTests
    {
        [Fact]
        public async Task Main_WritesExpectedGreetingAsync()
        {
            // Arrange
            var originalOut = Console.Out;
            using var writer = new StringWriter();
            Console.SetOut(writer);

            try
            {
                // Act
                await Program.Main(Array.Empty<string>());
            }
            finally
            {
                Console.SetOut(originalOut);
            }

            // Assert
            var output = writer.ToString();
            Assert.Contains("Hello from async master!", output);
            Assert.Contains("Learning Async/Await step by step", output);
            Assert.Contains("Master branch keeps async greetings fresh", output);
        }
    }
}

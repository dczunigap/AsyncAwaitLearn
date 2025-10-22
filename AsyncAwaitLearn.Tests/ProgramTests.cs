using System;
using System.IO;
using AsyncAwaitLearn;
using Xunit;

namespace AsyncAwaitLearn.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_WritesExpectedGreeting()
        {
            // Arrange
            var originalOut = Console.Out;
            using var writer = new StringWriter();
            Console.SetOut(writer);

            try
            {
                // Act
                Program.Main(Array.Empty<string>());
            }
            finally
            {
                Console.SetOut(originalOut);
            }

            // Assert
            var output = writer.ToString();
            Assert.Contains("Hello World! GitHub actions", output);
        }
    }
}

using System;
using System.IO;
using Xunit;
using ConsoleAppDI.src.Performers;
using ConsoleAppDI.src.Interfaces;

namespace ConsoleAppDI.tests
{
    public class ConsoleMessengerTests
    {
        [Fact]
        public void Write_WritesMessageToConsole()
        {
            // Arrange
            IMessenger messenger = new ConsoleMessenger();
            string expected = "Hello, DI world!";
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            messenger.Write(expected);

            // Assert
            var output = sw.ToString().Trim();
            Assert.Equal(expected, output);
        }
    }
}

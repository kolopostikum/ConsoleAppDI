using System;
using ConsoleAppDI.src.Coordinators;
using ConsoleAppDI.src.Interfaces;
using ConsoleAppDI.src.Performers;

namespace ConsoleAppDI.src
{
    public class Program()
    {
        /// <summary>
        /// Точка определения контрактера и связывания его с координатором.
        /// </summary>
        public static void Main()
        {
            ShowWelcomeMessage();

            string message = ReadUserMessage();

            IMessenger messenger = new ConsoleMessenger();

            var sender = new Sender(messenger);

            sender.Send(message);

            ShowCompletionMessage(message);
        }

        private static void ShowWelcomeMessage()
        {
            Console.WriteLine("[INFO] Welcome to ConsoleAppDI!");
            Console.WriteLine("[INFO] Please enter the message to send:");
        }

        private static string ReadUserMessage()
        {
            string input;
            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    Console.WriteLine("[ERROR] Message cannot be empty. Please try again.");
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        private static void ShowCompletionMessage(string message)
        {
            Console.WriteLine($"[INFO] Message successfully sent: \"{message}\"");
            Console.WriteLine("[INFO] Program finished.");
        }
    }
}

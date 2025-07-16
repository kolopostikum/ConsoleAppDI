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
            string message = "Hello world!";

            IMessenger messenger = new ConsoleMessenger();

            var sender = new Sender(messenger: messenger);//IoC

            sender.Send(message);
        }
    }
}

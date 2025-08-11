using System;
using ConsoleAppDI.src.Interfaces;


namespace ConsoleAppDI.src.Performers;

public class StubMessenger : IMessenger
{
    /// <summary>
    /// Последнее полученное сообщение (для тестирования).
    /// </summary>
    public string LastMessage { get; private set; } = "No messages";
    public void Write(string message)
    {
        LastMessage = message;
        // Не выводит ничего в консоль
    }
}

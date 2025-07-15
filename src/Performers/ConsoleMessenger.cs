using ConsoleAppDI.src.Interfaces;

namespace ConsoleAppDI.src.Performers;

/// <summary>
/// Реализатор поведения послания сообщения, отвязанное от координатора. 
/// Сохранение согласованности поведения подтверждается реализацией контракта IMessenger.
/// Поведение реализуется через вывод сообщения в консоль.  
/// </summary>
public class ConsoleMessenger : IMessenger
{
    /// <summary>
    /// Вариация поведения отправки сообщения через консоль.
    /// </summary>
    /// <param name="message">переданное сообщение</param>
    public void Write(string message)
    {
        Console.WriteLine(message);
    }
}

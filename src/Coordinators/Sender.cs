using ConsoleAppDI.src.Interfaces;

namespace ConsoleAppDI.src.Coordinators;

/// <summary>
/// Выделил отправителя с зависимостью от контракта, а не от реализации исполнителя.
/// Через внедрение зависимости от интерфейса в конструкторе получилось отделить логику.
/// </summary>
public class Sender
{
    private readonly IMessenger _messenger;
    public Sender(IMessenger messenger)
    {
        _ = messenger ?? throw new ArgumentNullException(nameof(messenger), "Messenger cannot be null");
        this._messenger = messenger;
    }

    /// <summary>
    /// Отправитель фиксирует ФАКТ отправки, 
    /// но отвественность за СПОСОБ отправки передана исполнителю контракта.
    /// </summary>
    /// <param name="message">сообщение к отправке</param>
    public void Send(string message)
    {
        _messenger.Write(message);
    }
}
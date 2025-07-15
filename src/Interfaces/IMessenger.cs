using System;

namespace ConsoleAppDI.src.Interfaces;

/// <summary>
/// Контракт, позволяющий инвертировать зависимость
/// между слоем исполнителя и слоем координатора. 
/// </summary>
public interface IMessenger
{
    /// <summary>
    /// Фиксация сообщения, переданного координатором исполнителю.
    /// </summary>
    /// <param name="message"></param>
    public void Write(string message);
}
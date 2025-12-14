using App.MessageBus.Models;

namespace App.MessageBus.Contracts;

public interface IMessageHandler
{
    void SendMessage(ProductMessage message);
}

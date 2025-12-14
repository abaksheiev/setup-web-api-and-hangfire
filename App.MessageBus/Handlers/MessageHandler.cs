using App.MessageBus.Contracts;
using App.MessageBus.Models;

namespace App.MessageBus.Handlers;

public class MessageHandler : IMessageHandler
{
    public void SendMessage(ProductMessage message)
    {;

        switch (message.Event)
        {
            case "ProductCreate":
                Console.WriteLine($"Proccessing event 'ProductCreate' for product {message.Id}");
                Thread.Sleep(5000);
                Console.WriteLine($"Proccessed event 'ProductCreate' for product {message.Id}");
                break;
            case "ProductDelete":
                Console.WriteLine($"Proccessing event 'ProductDelete' for product {message.Id}");
                Thread.Sleep(5000);
                Console.WriteLine($"Proccessed event 'ProductDelete' for product {message.Id}");
                break;
            default:
                throw new ArgumentException("Not supported Message Event Type");
        }
    }
}

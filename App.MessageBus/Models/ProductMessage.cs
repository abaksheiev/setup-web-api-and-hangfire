namespace App.MessageBus.Models;

public class ProductMessage
{
    public string Event { get; set; }
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }

    public string Description { get; set; }

    public static ProductMessage Delete(Guid id, string name, string description)
    {
        return new ProductMessage
        {
            Event = $"{EventType.ProductDelete}",
            Id = id,
            Name = name,
            Description = description
        };
    }

    public static ProductMessage Create(string name, string description)
    {
        return new ProductMessage
        {
            Event = $"{EventType.ProductCreate}",
            Name = name,
            Description = description,
        };
    }
}

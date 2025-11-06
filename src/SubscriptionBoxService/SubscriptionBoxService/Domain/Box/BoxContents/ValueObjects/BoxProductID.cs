namespace Domain.Box.BoxContents.ValueObjects;

public record BoxProductID
{
    private Guid Id { get; }
    private BoxProductID(Guid id)
    {
        Id = id;
    }

    public static BoxProductID Create(Guid id)
    {
        if (id == Guid.Empty || id == default)
        {
            throw new ArgumentException("Идентификатор товара коробки был пустым.");
        }

        return new BoxProductID(id);
    }

    public static BoxProductID Create()
    {
        Guid id = Guid.NewGuid();
        return new BoxProductID(id);
    }
}
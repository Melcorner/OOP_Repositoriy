namespace Domain.Box.ValueObjects;

public record BoxID
{
    private Guid Id { get; }
    private BoxID(Guid id)
    {
        Id = id;
    }

    public static BoxID Create(Guid id)
    {
        if (id == Guid.Empty || id == default)
        {
            throw new ArgumentException("Идентификатор коробки был пустым.");
        }

        return new BoxID(id);
    }

    public static BoxID Create()
    {
        Guid id = Guid.NewGuid();
        return new BoxID(id);
    }
}
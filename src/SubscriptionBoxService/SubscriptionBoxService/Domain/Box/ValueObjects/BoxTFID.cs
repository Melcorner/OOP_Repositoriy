namespace Domain.Box.ValueObjects;

public record BoxTFID
{
    public Guid Id { get; }
    private BoxTFID(Guid id)
    {
        Id = id;
    }

    public static BoxTFID Create(Guid id)
    {
        if (id == Guid.Empty || id == default)
        {
            throw new ArgumentException("Идентификатор тарифного плана коробки был пустым.");
        }

        return new BoxTFID(id);
    }

    public static BoxTFID Create()
    {
        Guid id = Guid.NewGuid();
        return new BoxTFID(id);
    }
}
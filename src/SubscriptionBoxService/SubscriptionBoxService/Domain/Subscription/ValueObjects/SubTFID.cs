namespace Domain.Subscription.ValueObjects;

public record SubTFID
{
    private Guid Id { get; }
    private SubTFID(Guid id)
    {
        Id = id;
    }

    public static SubTFID Create(Guid id)
    {
        if (id == Guid.Empty || id == default)
        {
            throw new ArgumentException("Идентификатор тарифного плана подписки был пустым.");
        }

        return new SubTFID(id);
    }

    public static SubTFID Create()
    {
        Guid id = Guid.NewGuid();
        return new SubTFID(id);
    }
}
namespace Domain.Subscription.ValueObjects;

public record SubID
{
    private Guid Id { get; }
    private SubID(Guid id)
    {
        Id = id;
    }

    public static SubID Create(Guid id)
    {
        if (id == Guid.Empty || id == default)
        {
            throw new ArgumentException("Идентификатор подписки был пустым.");
        }

        return new SubID(id);
    }

    public static SubID Create()
    {
        Guid id = Guid.NewGuid();
        return new SubID(id);
    }
}
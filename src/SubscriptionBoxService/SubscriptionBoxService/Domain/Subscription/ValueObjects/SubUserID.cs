namespace Domain.Subscription.ValueObjects;

public record SubUserID
{
    public Guid Id { get; }
    private SubUserID(Guid id)
    {
        Id = id;
    }

    public static SubUserID Create(Guid id)
    {
        if (id == Guid.Empty || id == default)
        {
            throw new ArgumentException("Идентификатор пользователя подписки был пустым.");
        }

        return new SubUserID(id);
    }

    public static SubUserID Create()
    {
        Guid id = Guid.NewGuid();
        return new SubUserID(id);
    }
}
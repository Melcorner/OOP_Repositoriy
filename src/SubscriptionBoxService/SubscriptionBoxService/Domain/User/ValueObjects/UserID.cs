namespace Domain.User.ValueObjects;

public record UserID
{
    private Guid Id { get; }
    private UserID(Guid id)
    {
        Id = id;
    }

    public static UserID Create(Guid id)
    {
        if (id == Guid.Empty || id == default)
        {
            throw new ArgumentException("Идентификатор пользователя был пустым.");
        }

        return new UserID(id);
    }

    public static UserID Create()
    {
        Guid id = Guid.NewGuid();
        return new UserID(id);
    }
}
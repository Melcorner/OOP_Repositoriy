namespace Domain.Delivery.ValueObjects;

public record DeliveryUserID
{
    private Guid Id { get; }
    private DeliveryUserID(Guid id)
    {
        Id = id;
    }

    public static DeliveryUserID Create(Guid id)
    {
        if (id == Guid.Empty || id == default)
        {
            throw new ArgumentException("Идентификатор пользователя был пустым.");
        }

        return new DeliveryUserID(id);
    }

    public static DeliveryUserID Create()
    {
        Guid id = Guid.NewGuid();
        return new DeliveryUserID(id);
    }
}
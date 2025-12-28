namespace Domain.Product.ValueObjects;

public record ProductID
{
    public Guid Id { get; }
    private ProductID(Guid id)
    {
        Id = id;
    }

    public static ProductID Create(Guid id)
    {
        if (id == Guid.Empty || id == default)
        {
            throw new ArgumentException("Идентификатор товара был пустым.");
        }

        return new ProductID(id);
    }

    public static ProductID Create()
    {
        Guid id = Guid.NewGuid();
        return new ProductID(id);
    }
}
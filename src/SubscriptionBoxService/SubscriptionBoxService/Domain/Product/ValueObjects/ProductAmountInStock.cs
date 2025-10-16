namespace Domain.Product.ValueObjects;

public record ProductAmountInStock
{
    public int Value { get; }

    private ProductAmountInStock(int value)
    {
        Value = value;
    }

    public static ProductAmountInStock Create(int value)
    {
        if (value < 0)
            throw new ArgumentException("Количество товара на складе не может быть отрицательным.");
        return new (value);
    }
}
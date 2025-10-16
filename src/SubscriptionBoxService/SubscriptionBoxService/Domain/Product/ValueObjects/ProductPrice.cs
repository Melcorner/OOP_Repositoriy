namespace Domain.Product.ValueObjects;

public record ProductPrice
{
    public double Value { get; }

    private ProductPrice(double value)
    {
        Value = value;
    }

    public static ProductPrice Create(double value)
    {
        if (value <= 0 || value >5000)
            throw new ArgumentException("Некорректная цена товара.");
        return new (value);
    }
}
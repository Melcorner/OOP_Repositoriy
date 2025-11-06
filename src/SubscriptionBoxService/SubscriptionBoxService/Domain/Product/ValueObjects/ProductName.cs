namespace Domain.Product.ValueObjects;

public record ProductName
{
    public string Value { get; }

    private ProductName(string value)
    {
        Value = value;
    }

    public static ProductName Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Наименование товара было пустым.");
        }

        string formatted = value.Trim();
        return new ProductName(formatted);
    }
}
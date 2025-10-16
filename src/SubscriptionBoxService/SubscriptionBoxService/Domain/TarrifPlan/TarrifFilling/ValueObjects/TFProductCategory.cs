namespace Domain.TarrifPlan.TarrifFilling.ValueObjects;

public enum ProductCategoryType
{
    Coffee,
    Candles,
    Books
}

public record TFProductCategory
{
    public ProductCategoryType Type { get;}

    public TFProductCategory(ProductCategoryType type)
    {
        Type = type;
    }
}
namespace Domain.Product.ValueObjects;

public enum ProductCategoryType
{
    Coffee,
    Candles,
    Books
}

public record ProductCategory
{
    public ProductCategoryType Type { get;}

    public ProductCategory(ProductCategoryType type)
    {
        Type = type;
    }
}
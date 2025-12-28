using Domain.Utilities;

namespace Domain.Product.ValueObjects.Enumerations;

public class ProductCategory : Enumeration<ProductCategory>
{
    protected ProductCategory(int key, string name)
        : base(key, name){ }
}
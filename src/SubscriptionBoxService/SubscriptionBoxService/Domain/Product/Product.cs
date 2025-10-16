using Domain.Product.ValueObjects;

namespace Domain.Product;

public class Product
{
    public ProductID ProductId { get; }
    public ProductName ProductName { get; }
    public ProductPrice ProductPrice { get; }
    public ProductCategory ProductCategory { get; }
    public ProductAmountInStock ProductAmountInStock { get; }

    public Product(
        ProductID productId,
        ProductName productName,
        ProductPrice productPrice,
        ProductCategory productCategory,
        ProductAmountInStock productAmountInStock)
    {
        ProductId = productId;
        ProductName = productName;
        ProductPrice = productPrice;
        ProductCategory = productCategory;
        ProductAmountInStock = productAmountInStock;
    }
}
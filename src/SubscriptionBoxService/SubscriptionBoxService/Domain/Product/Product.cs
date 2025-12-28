using Domain.Product.ValueObjects;
using Domain.Product.ValueObjects.Enumerations;

namespace Domain.Product;

public sealed class Product
{
    public Box.Box Box { get; }
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
        ProductAmountInStock productAmountInStock,
        Box.Box box)
    {
        ProductId = productId;
        ProductName = productName;
        ProductPrice = productPrice;
        ProductCategory = productCategory;
        ProductAmountInStock = productAmountInStock;
        Box = box;
    }
}
using Domain.Box.BoxContents.ValueObjects;

namespace Domain.Box.BoxContents;

public class BoxContents
{
    public BoxProductID ProductID { get;}
    public BoxProductAmount Amount { get; }
    
    public BoxContents(BoxProductID productID, BoxProductAmount amount)
    {
        ProductID = productID;
        Amount = amount;
    }
}
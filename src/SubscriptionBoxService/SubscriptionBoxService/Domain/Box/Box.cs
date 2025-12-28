using Domain.Box.BoxContents.ValueObjects;
using Domain.Box.ValueObjects;
using Domain.Product.ValueObjects.Enumerations;

namespace Domain.Box;

public sealed class Box
{
    public BoxID BoxID { get;}
    public BoxTFID BoxTFID { get;}
    public BoxTrackNumber BoxTrackNumber { get;}

    public BoxContents.BoxContents Contents { get; }

    public Box(
        BoxID boxID,
        BoxTFID boxTFID,
        BoxProductID productID,
        BoxProductAmount productAmount,
        BoxTrackNumber trackNumber)
    {
        BoxTrackNumber = trackNumber;
        BoxID = boxID;
        BoxTFID = boxTFID;
        Contents = new BoxContents.BoxContents(productID, productAmount);
    }
}
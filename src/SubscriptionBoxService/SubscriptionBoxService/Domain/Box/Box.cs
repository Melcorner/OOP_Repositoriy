using Domain.Box.ValueObjects;
using Domain.Product;

namespace Domain.Box;

public class Box
{
    public BoxID BoxID { get;}
    public BoxTFID BoxTFID { get;}
    public BoxTrackNumber BoxTrackNumber { get;}

    public IReadOnlyCollection<BoxContents.BoxContents> Contents { get;}

    public Box(
        BoxID boxID,
        BoxTFID boxTFID,
        IEnumerable<BoxContents.BoxContents> contents)
    {
        BoxID = boxID;
        BoxTFID = boxTFID;
        Contents = contents.ToList();
    }
}
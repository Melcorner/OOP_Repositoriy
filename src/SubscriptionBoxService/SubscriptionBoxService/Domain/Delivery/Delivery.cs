using Domain.Delivery.ValueObjects;

namespace Domain.Delivery;

public class Delivery
{
    public DeliveryBoxTrackNum TarckNumber { get; }
    public DeliveryUserID UserID { get; }
    public DeliveryUserAddress UserAddress { get; }
    public DeliveryStatus Status { get; }

    public Delivery(
        DeliveryBoxTrackNum tarckNumber,
        DeliveryUserID userID,
        DeliveryUserAddress userAddress,
        DeliveryStatus status)
    {
        TarckNumber = tarckNumber;
        UserID = userID;
        UserAddress = userAddress;
        Status = status;
    }
}
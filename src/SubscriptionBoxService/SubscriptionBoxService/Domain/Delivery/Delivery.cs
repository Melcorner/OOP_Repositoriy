using Domain.Delivery.ValueObjects;
using Domain.Delivery.ValueObjects.Enumerations;

namespace Domain.Delivery;

public sealed class Delivery
{
    public DeliveryBoxTrackNum TrackNumber { get; }
    public DeliveryUserID UserID { get; }
    public DeliveryUserAddress UserAddress { get; }
    public DeliveryStatus Status { get; }

    public Delivery(
        DeliveryBoxTrackNum trackNumber,
        DeliveryUserID userID,
        DeliveryUserAddress userAddress,
        DeliveryStatus status)
    {
        TrackNumber = trackNumber;
        UserID = userID;
        UserAddress = userAddress;
        Status = status;
    }
}
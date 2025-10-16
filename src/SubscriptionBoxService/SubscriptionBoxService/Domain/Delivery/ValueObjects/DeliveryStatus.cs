namespace Domain.Delivery.ValueObjects;

public enum DeliveryStatusType
{
    InAssembly,
    InTransit,
    Delivered
}

public record DeliveryStatus
{
    public DeliveryStatusType Status { get;}

    public DeliveryStatus(DeliveryStatusType status)
    {
        Status = status;
    }
}
namespace Domain.Delivery.ValueObjects.Enumerations;

public class DeliveryStatusDelivered : DeliveryStatus
{
    public DeliveryStatusDelivered()
        : base(2, "Доставлено"){}
}
namespace Domain.Delivery.ValueObjects.Enumerations;

public class DeliveryStatusInTransit : DeliveryStatus
{
    public DeliveryStatusInTransit()
        :base(1, "В доставке"){}
}
using Domain.Utilities;

namespace Domain.Delivery.ValueObjects.Enumerations;

public abstract class DeliveryStatus : Enumeration<DeliveryStatus>
{
    protected DeliveryStatus(int key, string name)
        : base(key, name){ }
}
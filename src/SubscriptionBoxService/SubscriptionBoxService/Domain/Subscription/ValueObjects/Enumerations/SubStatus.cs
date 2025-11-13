using Domain.Utilities;

namespace Domain.Subscription.ValueObjects.Enumerations;

public abstract class SubStatus : Enumeration<SubStatus>
{
    protected SubStatus(int key, string name)
        : base(key, name){ }
}
using Domain.Utilities;

namespace Domain.Subscription.ValueObjects.Enumerations;

public class SubStatus : Enumeration<SubStatus>
{
    protected SubStatus(int key, string name)
        : base(key, name){ }
}
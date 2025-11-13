using Domain.Utilities;

namespace Domain.TarrifPlan.TarrifFilling.ValueObjects.Enumerations;

public abstract class TFCategory : Enumeration<TFCategory>
{
    protected TFCategory(int key, string name)
        : base(key, name){ }
}
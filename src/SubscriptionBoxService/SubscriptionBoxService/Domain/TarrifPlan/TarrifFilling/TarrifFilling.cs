using Domain.TarrifPlan.TarrifFilling.ValueObjects;
using Domain.TarrifPlan.TarrifFilling.ValueObjects.Enumerations;

namespace Domain.TarrifPlan.TarrifFilling;

public class TarrifFilling
{
    public TFCategory Category { get; }
    public TFProductAmount Amount { get; }

    public TarrifFilling(TFCategory category, TFProductAmount amount)
    {
        Category = category;
        Amount = amount;
    }
}
using Domain.TarrifPlan.TarrifFilling.ValueObjects;

namespace Domain.TarrifPlan.TarrifFilling;

public class TarrifFilling
{
    public TFProductCategory Category { get; }
    public TFProductAmount Amount { get; }

    public TarrifFilling(TFProductCategory category, TFProductAmount amount)
    {
        Category = category;
        Amount = amount;
    }
}
using Domain.TarrifPlan.TarrifFilling.ValueObjects;
using Domain.TarrifPlan.TarrifFilling.ValueObjects.Enumerations;
using Domain.TarrifPlan.ValueObjects;

namespace Domain.TarrifPlan;

public sealed class TarrifPlan
{
    public TarrifPlanID TarrifPlanId { get; }
    public TarrifPlanName TarrifPlanName { get; }
    public TarrifPlanPrice TarrifPlanPrice { get; }
    public TarrifFilling.TarrifFilling Fillings { get; }

    public TarrifPlan(
        TarrifPlanID id, 
        TarrifPlanName name,
        TarrifPlanPrice price, 
        TFCategory category,
        TFProductAmount  productAmount
        )
    {
        TarrifPlanId = id;
        TarrifPlanName = name;
        TarrifPlanPrice = price;
        Fillings = new TarrifFilling.TarrifFilling(category, productAmount);
    }
}
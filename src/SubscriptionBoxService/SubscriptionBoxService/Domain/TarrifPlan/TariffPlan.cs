using Domain.TarrifPlan.ValueObjects;

namespace Domain.TarrifPlan;

public class TarrifPlan
{
    public TarrifPlanID TarrifPlanId { get; }
    public TarrifPlanName TarrifPlanName { get; }
    public TarrifPlanPrice TarrifPlanPrice { get; }
    public IReadOnlyCollection<TarrifFilling.TarrifFilling> Fillings { get; }

    public TarrifPlan(
        TarrifPlanID id, 
        TarrifPlanName name,
        TarrifPlanPrice price, 
        IEnumerable<TarrifFilling.TarrifFilling> fillings
        )
    {
        TarrifPlanId = id;
        TarrifPlanName = name;
        TarrifPlanPrice = price;
        Fillings = fillings.ToList();
    }
}
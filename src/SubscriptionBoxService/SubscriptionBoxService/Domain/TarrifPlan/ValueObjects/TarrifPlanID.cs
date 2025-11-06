namespace Domain.TarrifPlan.ValueObjects;

public record TarrifPlanID
{
    public Guid Id { get; }
    private TarrifPlanID(Guid id) => Id = id;
    public static TarrifPlanID Create(Guid id)
    {
        if (id == Guid.Empty || id == default)
        {
            throw new ArgumentException("Идентификатор тарифного плана был пустым.");
        }

        return new TarrifPlanID(id);
    }

    public static TarrifPlanID Create()
    {
        Guid id = Guid.NewGuid();
        return new TarrifPlanID(id);
    }
}
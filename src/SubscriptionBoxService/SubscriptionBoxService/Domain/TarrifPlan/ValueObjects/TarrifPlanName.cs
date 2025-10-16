namespace Domain.TarrifPlan.ValueObjects;

public record TarrifPlanName
{
    public string Value { get; }

    private TarrifPlanName(string value)
    {
        Value = value;
    }

    public static TarrifPlanName Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Название тарифного плана было пустым.");
        }

        string formatted = value.Trim();
        return new TarrifPlanName(formatted);
    }
}

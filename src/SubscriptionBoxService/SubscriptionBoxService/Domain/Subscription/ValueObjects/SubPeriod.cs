namespace Domain.Subscription.ValueObjects;

public record SubPeriod
{
    public int Value { get; }

    private SubPeriod(int value)
    {
        Value = value;
    }

    public static SubPeriod Create(int value)
    {
        if (value <= 0 || value > 12)
            throw new ArgumentException("Некорректный период подписки.");
        return new (value);
    }
}
namespace Domain.Subscription.ValueObjects;

public record SubPrice
{
    public double Value { get; }

    private SubPrice(double value)
    {
        Value = value;
    }

    public static SubPrice Create(double value)
    {
        if (value <= 0)
            throw new ArgumentException("Некорректная стоимость подписки.");
        return new (value);
    }
}
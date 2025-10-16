namespace Domain.Subscription.ValueObjects;

public record SubDate
{
    public DateOnly Date { get; }

    private SubDate(DateOnly date)
    {
        Date = date;
    }

    public static SubDate Create(DateOnly date)
    {
        if (date == default)
        {
            throw new ArgumentException("Дата указана некорректно.");
        }

        return new SubDate(date);
    }
}
namespace Domain.User.UserProfile.ValueObjects;

public record struct UserDoB
{
    public DateOnly Date { get; }

    private UserDoB(DateOnly date)
    {
        Date = date;
    }

    public static UserDoB Create(DateOnly date)
    {
        if (date == default)
        {
            throw new ArgumentException("Дата указана некорректно.");
        }
        if (date >= DateOnly.FromDateTime(DateTime.Now))
        {
            throw new ArgumentException("Дата рождения указана некорректно.");
        }

        return new UserDoB(date);
    }
}
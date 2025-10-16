namespace Domain.User.UserCredentials.ValueObjects;

public record UserLogin
{
    public string Value { get; }

    private UserLogin(string value)
    {
        Value = value;
    }

    public static UserLogin Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Логин пользователя был пустым.");
        }
        string formatted = value.Trim();
        return new UserLogin(formatted);
    }
}
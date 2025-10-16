namespace Domain.User.UserCredentials.ValueObjects;

public record UserPassword
{
    public string Value { get; }

    private UserPassword(string value)
    {
        Value = value;
    }
    public static UserPassword Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Пароль пользователя был пустым.");
        }
        string formatted = value.Trim();
        return new UserPassword(formatted);
    }
}
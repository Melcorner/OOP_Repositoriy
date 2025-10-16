namespace Domain.User.UserProfile.ValueObjects;

public record UserName
{
    public string Value { get; }

    private UserName(string value)
    {
        Value = value;
    }

    public static UserName Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Имя пользователя было пустым.");
        }

        string formatted = value.Trim();
        return new UserName(formatted);
    }
}
namespace Domain.User.UserProfile.ValueObjects;

public record UserSurname
{
    public string Value { get; }

    private UserSurname(string value)
    {
        Value = value;
    }
    public static UserSurname Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Фамилия пользователя была пустой.");
        }

        string formatted = value.Trim();
        return new UserSurname(formatted);
    }
}
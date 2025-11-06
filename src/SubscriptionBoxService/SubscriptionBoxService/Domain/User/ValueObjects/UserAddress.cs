namespace Domain.User.ValueObjects;

public record UserAddress
{
    public string Value { get; }

    private UserAddress(string value)
    {
        Value = value;
    }

    public static UserAddress Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Адрес был пустым.");
        }

        string formatted = value.Trim();

        return new UserAddress(formatted);
    }
}
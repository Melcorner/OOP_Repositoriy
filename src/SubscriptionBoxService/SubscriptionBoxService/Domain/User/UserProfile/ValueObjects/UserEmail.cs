using System.Text.RegularExpressions;

namespace Domain.User.UserProfile.ValueObjects;

public record UserEmail
{
    public string Value { get; }

    private UserEmail(string value)
    {
        Value = value;
    }

    public static UserEmail Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Почта не была указана.");
        }

        string formatted = value.Trim();
        if (!IsUserEmailValid(formatted))
        {
            throw new ArgumentException("Почта была некорректной.");
        }
        return Create(formatted);
    }

    private static bool IsUserEmailValid(string email)
    {
        Match match = Regex.Match(email, @"(\w+) [@] (\w+) [.](\w+)");
        return match.Success;
    }
}
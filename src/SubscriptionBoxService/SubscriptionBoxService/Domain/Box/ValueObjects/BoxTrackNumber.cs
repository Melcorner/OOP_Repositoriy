namespace Domain.Box.ValueObjects;

public record BoxTrackNumber
{
    public string Value { get; }

    private BoxTrackNumber(string value)
    {
        Value = value;
    }

    public static BoxTrackNumber Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Трек-номер коробки был пустым.");
        }

        string formatted = value.Trim();
        return new BoxTrackNumber(formatted);
    }
}
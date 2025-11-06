namespace Domain.Delivery.ValueObjects;

public record DeliveryBoxTrackNum
{
    public string Value { get; }

    private DeliveryBoxTrackNum(string value)
    {
        Value = value;
    }

    public static DeliveryBoxTrackNum Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Трек-номер коробки был пустым.");
        }

        string formatted = value.Trim();
        return new DeliveryBoxTrackNum(formatted);
    }
}
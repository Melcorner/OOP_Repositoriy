namespace Domain.Delivery.ValueObjects;

public record DeliveryUserAddress
{
    public string Value { get; }

    private DeliveryUserAddress(string value)
    {
        Value = value;
    }

    public static DeliveryUserAddress Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Адрес доставки был пустым.");
        }

        string formatted = value.Trim();

        return new DeliveryUserAddress(formatted);
    }
}
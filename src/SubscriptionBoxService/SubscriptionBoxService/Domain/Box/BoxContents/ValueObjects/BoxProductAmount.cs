namespace Domain.Box.BoxContents.ValueObjects;

public record BoxProductAmount
{
    public int Value { get; }

    private BoxProductAmount(int value)
    {
        Value = value;
    }

    public static BoxProductAmount Create(int value)
    {
        if (value <= 0)
            throw new ArgumentException("Количество товара в коробке некорректно.");
        return new (value);
    }
}
namespace Domain.TarrifPlan.TarrifFilling.ValueObjects;

public record TFProductAmount
{
    public int Amount { get; }

    private TFProductAmount(int amount)
    {
        Amount = amount;
    }

    public static TFProductAmount Create(int amount)
    {
        if (amount <= 0)
        {
            throw new AggregateException("Количество товара в тарифе введено некорректно.");
        }
        return new TFProductAmount(amount);
    }
}
namespace Domain.TarrifPlan.ValueObjects;

public record TarrifPlanPrice
{
    public int Price { get; }

    private TarrifPlanPrice(int price)
    {
        Price = price;
    }

    public static TarrifPlanPrice Create(int price)
    {
        if (price <= 0)
        {
            throw new AggregateException("Стоимость тарифа введена некорректно.");
        }
        return new TarrifPlanPrice(price);
    }
}
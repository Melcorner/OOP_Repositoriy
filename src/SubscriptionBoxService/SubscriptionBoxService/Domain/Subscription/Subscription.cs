using Domain.Subscription.ValueObjects;

namespace Domain.Subscription;

public class Subscription
{
    public SubID Id { get; }
    public SubDate Date { get; }
    public SubPeriod Period { get; }
    public SubStatus Status { get; }
    public SubPrice Price { get; }
    public SubUserID UserId { get; }
    public SubTFID TarrifPlanID { get; }

    public Subscription(
        SubID id,
        SubDate date,
        SubPeriod period,
        SubStatus status,
        SubPrice price,
        SubUserID userId,
        SubTFID TarrifPlanId)
    {
        Id = id;
        Date = date;
        Period = period;
        Status = status;
        Price = price;
        UserId = userId;
        TarrifPlanID = TarrifPlanId;
    }
}
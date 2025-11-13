namespace Domain.Subscription.ValueObjects.Enumerations;

public class SubStatusCancelled : SubStatus
{
    public SubStatusCancelled()
        :base(2, "Отменена"){}
}
namespace Domain.Subscription.ValueObjects;

public enum SubStatusType
{
     Active,
     Inactive,
     Cancelled,
     Expired
}

public record SubStatus
{
    public SubStatusType Status { get;}

    public SubStatus(SubStatusType status)
    {
        Status = status;
    }
}
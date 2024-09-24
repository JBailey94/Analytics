using Analytics.Domain.Abstractions;

public class DomainEvent<T> : IEvent
{
    public DateTime OccurredOn { get; private set; }
    public T Data { get; private set; }

    public DomainEvent(T data)
    {
        OccurredOn = DateTime.UtcNow;
        Data = data;
    }
}

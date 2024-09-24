namespace Analytics.Domain.Abstractions
{
    public interface IEvent
    {
        DateTime OccurredOn { get; }
    }
}

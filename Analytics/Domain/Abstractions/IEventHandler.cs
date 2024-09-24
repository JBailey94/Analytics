using Analytics.Domain.Abstractions;

public interface IEventHandler<TEvent> where TEvent : IEvent
{
    void Handle(TEvent eventToHandle);
}

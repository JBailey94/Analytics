public class UserRegisteredEventData
{
    public string UserName { get; set; }
    public string Email { get; set; }
}

public class UserRegisteredEvent : DomainEvent<UserRegisteredEventData>
{
    public UserRegisteredEvent(UserRegisteredEventData data) : base(data)
    {
    }
}

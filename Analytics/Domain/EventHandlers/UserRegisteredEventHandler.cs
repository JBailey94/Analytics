public class UserRegisteredEventHandler : IEventHandler<UserRegisteredEvent>
{
    public void Handle(UserRegisteredEvent eventToHandle)
    {
        // Handle user registered domain event
        var userData = eventToHandle.Data;
        Console.WriteLine($"User Registered: {userData.UserName}, {userData.Email}");
    }
}

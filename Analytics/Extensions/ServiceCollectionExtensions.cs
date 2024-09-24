using Microsoft.Extensions.DependencyInjection;

namespace Analytics.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAnalyticalServices(this IServiceCollection services)
        {
            // Register event handlers
            services.AddTransient<IEventHandler<UserRegisteredEvent>, UserRegisteredEventHandler>();

            // Register the EventDispatcher
            services.AddSingleton<EventDispatcher>();
        }
    }
}

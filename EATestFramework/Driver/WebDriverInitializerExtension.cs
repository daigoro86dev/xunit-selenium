using Microsoft.Extensions.DependencyInjection;
using EATestFramework.Settings;

namespace EATestFramework.Driver
{
    public static class WebDriverInitializerExtension
    {
        public static IServiceCollection UseWebDriverInitializer(this IServiceCollection services, BrowserType browserType)
        {
            services.AddSingleton(new TestSettings { BrowserType = browserType });

            return services;
        }
    }
}

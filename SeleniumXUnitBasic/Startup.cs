using Microsoft.Extensions.DependencyInjection;
using SeleniumXUnitBasic.Driver;

namespace SeleniumXUnitBasic
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.UseWebDriverInitializer(BrowserType.Firefox);
            services.AddScoped<IBrowserDriver, BrowserDriver>();
            services.AddScoped<IDriverFixture, DriverFixture>();
        }
    }
}

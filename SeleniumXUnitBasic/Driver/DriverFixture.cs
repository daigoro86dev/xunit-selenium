using OpenQA.Selenium;
using SeleniumXUnitBasic.Settings;

namespace SeleniumXUnitBasic.Driver
{
    public class DriverFixture : IDriverFixture
    {
        IWebDriver driver;
        private readonly IBrowserDriver browserDriver;
        private readonly TestSettings testSettings;

        public DriverFixture(TestSettings testSettings, IBrowserDriver browserDriver)
        {
            this.testSettings = testSettings;
            this.browserDriver = browserDriver;
            driver = GetWebDriver();
        }

        public IWebDriver Driver => driver;

        private IWebDriver GetWebDriver()
        {
            return testSettings.BrowserType switch
            {
                BrowserType.Chrome => browserDriver.GetChromeDriver(),
                BrowserType.Firefox => browserDriver.GetFirefoxDriver(),
                BrowserType.Edge => browserDriver.GetEdgeDriver(),
                _ => browserDriver.GetChromeDriver()
            };
        }

    }
}

using EATestFramework.Driver;
using OpenQA.Selenium;

namespace EATestProject.Pages
{
    public interface IHomePage
    {
        void CreateProduct();
    }

    public class HomePage : IHomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IDriverFixture driverFixture) => _driver = driverFixture.Driver;

        IWebElement lnkProduct => _driver.FindElement(By.LinkText("Product"));
        IWebElement lnkCreate => _driver.FindElement(By.LinkText("Create"));

        public void CreateProduct()
        {
            lnkProduct.Click();
            lnkCreate.Click();
        }
    }
}

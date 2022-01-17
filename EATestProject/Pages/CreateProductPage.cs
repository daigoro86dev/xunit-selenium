using EATestFramework.Driver;
using OpenQA.Selenium;

namespace EATestProject.Pages
{
    internal class CreateProductPage
    {
        private readonly IWebDriver _driver;

        public CreateProductPage(IDriverFixture driverFixture)
        {
            _driver = driverFixture.Driver;
        }

        IWebElement txtName => _driver.FindElement(By.Id("Name"));
        IWebElement txtDescription =>  _driver.FindElement(By.Id("Description"));
        IWebElement txtPrice => _driver.FindElement(By.Id("Price"));
        IWebElement ddlProductType => _driver.FindElement(By.Id("ProductType"));
        IWebElement btnCreate => _driver.FindElement(By.Id("Create"));

    }
}

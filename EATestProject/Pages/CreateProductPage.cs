using EATestFramework.Driver;
using EATestProject.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EATestProject.Pages
{
    public interface ICreateProductPage
    {
        void EnterProductDetails(Product product);
    }

    public class CreateProductPage : ICreateProductPage
    {
        private readonly IWebDriver _driver;

        public CreateProductPage(IDriverFixture driverFixture) => _driver = driverFixture.Driver;

        IWebElement txtName => _driver.FindElement(By.Id("Name"));
        IWebElement txtDescription => _driver.FindElement(By.Id("Description"));
        IWebElement txtPrice => _driver.FindElement(By.Id("Price"));
        IWebElement ddlProductType => _driver.FindElement(By.Id("ProductType"));
        IWebElement btnCreate => _driver.FindElement(By.Id("Create"));

        public void EnterProductDetails(Product product)
        {
            txtName.SendKeys(product.Name);
            txtDescription.SendKeys(product.Description);
            txtPrice.SendKeys(product.Price.ToString());
            var select = new SelectElement(ddlProductType);
            select.SelectByText(product.ProductType.ToString());
            btnCreate.Click();
        }
    }
}

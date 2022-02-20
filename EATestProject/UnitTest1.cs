using EATestFramework.Driver;
using EATestProject.Model;
using EATestProject.Pages;
using OpenQA.Selenium;
using System;
using Xunit;

namespace EATestProject
{
    public class UnitTest1 : IDisposable
    {
        private readonly IHomePage homePage;
        private readonly ICreateProductPage createProductPage;
        IWebDriver driver;

        public UnitTest1(IDriverFixture driverFixture, IHomePage homePage, ICreateProductPage createProductPage)
        {
            driver = driverFixture.Driver;
            driver.Navigate().GoToUrl(new Uri("http://localhost:5001/"));
            this.homePage = homePage;
            this.createProductPage = createProductPage;
        }

        public void Dispose()
        {
            driver.Quit();
            driver.Dispose();
        }

        [Fact]
        public void Test1()
        {
            homePage.CreateProduct();
            createProductPage.EnterProductDetails(new Product
            {
                Name = "AutoProduct",
                Description = "AutoDescription",
                Price = 12345,
                ProductType = ProductType.PERIPHARALS
            });
        }
    }
}
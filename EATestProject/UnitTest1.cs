using EATestFramework.Driver;
using EATestProject.Model;
using EATestProject.Pages;
using OpenQA.Selenium;
using System;
using Xunit;

namespace EATestProject
{
    public class UnitTest1
    {
        private readonly IDriverFixture driverFixture;
        
        IWebDriver driver;

        public UnitTest1(IDriverFixture driverFixture)
        {
            driver = driverFixture.Driver;
            driver.Navigate().GoToUrl(new Uri("http://localhost:5001/"));
            this.driverFixture = driverFixture;
        }

        public void Dispose()
        {
            driver.Quit();
            driver.Dispose();
        }

        [Fact]
        public void Test1()
        {
            HomePage homePage = new HomePage(driverFixture);
            CreateProductPage createProductPage = new CreateProductPage(driverFixture);

            homePage.CreateProduct();
            createProductPage.EnterProductDetails(new Product
            { 
                Name= "AutoProduct",
                Description = "AutoDescription",
                Price = 12345,
                ProductType = ProductType.PERIPHARALS
            });
        }
    }
}
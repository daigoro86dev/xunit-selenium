using EATestFramework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace EATestFramework
{
    public class UnitTest2 : IDisposable
    {
        IWebDriver? driver;

        public UnitTest2(IDriverFixture driverFixture)
        {
            driver = driverFixture.Driver;
            driver.Navigate().GoToUrl(new Uri("http://localhost:5001/"));
        }

        public void Dispose()
        {

            driver.Quit();
            driver.Dispose();

        }

        [Fact]
        public void Test4()
        {
            driver.FindElement(By.LinkText("Product")).Click();
            driver.FindElement(By.LinkText("Create")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("Laptop");
            driver.FindElement(By.Id("Description")).SendKeys("Dell");
            driver.FindElement(By.Id("Price")).SendKeys("2000");

            var select = new SelectElement(driver.FindElement(By.Id("ProductType")));
            select.SelectByValue("2");
            driver.FindElement(By.Id("Create")).Submit();

        }

        [Fact]
        public void Test5()
        {
            driver.FindElement(By.LinkText("Product")).Click();
            driver.FindElement(By.LinkText("Create")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("PC");
            driver.FindElement(By.Id("Description")).SendKeys("Gaming PC");
            driver.FindElement(By.Id("Price")).SendKeys("3000");

            var select = new SelectElement(driver.FindElement(By.Id("ProductType")));
            select.SelectByValue("2");
            driver.FindElement(By.Id("Create")).Submit();

        }
    }
}
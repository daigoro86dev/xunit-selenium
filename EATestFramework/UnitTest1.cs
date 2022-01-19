using EATestFramework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace EATestFramework
{
    public class UnitTest1 : IDisposable
    {
        IWebDriver driver;

        public UnitTest1(IDriverFixture driverFixture)
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
        public void Test1()
        {
            driver.FindElement(By.LinkText("Product")).Click();
            driver.FindElement(By.LinkText("Create")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("Table");
            driver.FindElement(By.Id("Description")).SendKeys("Standing Table");
            driver.FindElement(By.Id("Price")).SendKeys("100");

            var select = new SelectElement(driver.FindElement(By.Id("ProductType")));
            select.SelectByValue("2");
            driver.FindElement(By.Id("Create")).Submit();

        }

        [Fact]
        public void Test2()
        {
            driver.FindElement(By.LinkText("Product")).Click();
            driver.FindElement(By.LinkText("Create")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("Chair");
            driver.FindElement(By.Id("Description")).SendKeys("Sitting Chair");
            driver.FindElement(By.Id("Price")).SendKeys("100");

            var select = new SelectElement(driver.FindElement(By.Id("ProductType")));
            select.SelectByValue("2");
            driver.FindElement(By.Id("Create")).Submit();

        }

        [Fact]
        public void Test3()
        {
            driver.FindElement(By.LinkText("Product")).Click();
            driver.FindElement(By.LinkText("Create")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("Desk");
            driver.FindElement(By.Id("Description")).SendKeys("Standing Desk");
            driver.FindElement(By.Id("Price")).SendKeys("100");

            var select = new SelectElement(driver.FindElement(By.Id("ProductType")));
            select.SelectByValue("2");
            driver.FindElement(By.Id("Create")).Submit();

        }
    }
}
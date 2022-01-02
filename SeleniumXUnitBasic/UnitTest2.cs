using Autofac;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumXUnitBasic.Driver;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Xunit;

namespace SeleniumXUnitBasic
{
    public class UnitTest2 : IDisposable
    {
        IWebDriver? driver;
        IContainer container;

        public UnitTest2()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BrowserDriver>().As<IBrowserDriver>();
            container = builder.Build();

            var driverFixture = new DriverFixture(container, Driver.BrowserType.Edge);
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
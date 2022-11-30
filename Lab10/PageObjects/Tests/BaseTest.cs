using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver("D:\\WebDrivers\\Chrome");
            driver.Navigate().GoToUrl("https://pass.rw.by/ru/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
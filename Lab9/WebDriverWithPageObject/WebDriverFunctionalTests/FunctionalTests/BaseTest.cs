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
            driver.Navigate().GoToUrl("https://pastebin.com");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
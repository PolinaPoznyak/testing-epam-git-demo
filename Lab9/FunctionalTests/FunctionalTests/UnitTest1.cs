using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FunctionalTests
{
    public class Tests
    {
        [Test]
        public void ViewScoreboardOfMinskStation()
        {
            IWebDriver driver = new ChromeDriver("D:\\WebDrivers\\Chrome");
            driver.Url = "https://pass.rw.by/ru/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//span[text()='Онлайн-табло']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//input[@value='Да']")).Click();
            driver.Close();
        }
    }
}
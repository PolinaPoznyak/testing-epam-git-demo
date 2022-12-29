using OpenQA.Selenium;
using System;

namespace Framework.Pages
{
    public class OnlineScoreboardPage
    {
        private IWebDriver driver;

        private const string BASE_URL = "https://pass.rw.by/ru/tablo/";

        private IWebElement btnConfirmStation => driver.FindElement(By.XPath("//input[@value='Да']"));
        private IWebElement checkStation => driver.FindElement(By.XPath("//*[@id=\"cityPopupTrigger\"]/span"));

        public OnlineScoreboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Console.WriteLine("OnlineScoreboardPage Page opened");
        }

        public void ClickConfirmStation() => btnConfirmStation.Click();
        public string GetStationName() => checkStation.Text;
    }
}

using OpenQA.Selenium;

namespace Framework.Pages
{
    public class SchedulePage
    {
        private IWebDriver _driver;

        private IWebElement btnSelectPlaces => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[2]/div[3]/div[2]/div[1]/div[3]/div/div[1]/div/div[4]/div[2]/form/a"));
        private IWebElement checkScheduleStation => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[2]/div[1]/div/div[1]"));
        private IWebElement checkTrainNum => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[2]/div[1]/div/div[2]/span"));

        public SchedulePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public void ClickToSelectPlace() => btnSelectPlaces.Click();
        public string GetScheduleStationHeader() => checkScheduleStation.Text;
        public string GetTrainNum() => checkTrainNum.Text;
    }
}

using OpenQA.Selenium;
namespace PageObjects
{
    public class SelectedTrain : BasePage
    {
        public SelectedTrain(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement btnChooseRailcar => driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div/div/div[2]/main/div/div[2]/div[3]/div/div/div[2]/div[1]/div[2]/div/span/span"));
        private IWebElement btnChoosePlace => driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div/div/div[2]/main/div/div[2]/div[3]/div/div/div[2]/div[2]/div/div/div/div[1]/div/div[2]/div[1]/div[4]/div/div/div[21]/span"));
        private IWebElement btnEnterPassengerData => driver.FindElement(By.XPath("//a [text()='Ввести данные пассажиров']"));

        public void ClickChooseRailcar() => btnChooseRailcar.Click();
        public void ClickChoosePlace() => btnChoosePlace.Click();
        public void ClickEnterPassengerData() => btnEnterPassengerData.Click();
    }
}

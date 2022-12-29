using OpenQA.Selenium;

namespace Framework.Pages
{
    public class SelectedTrain
    {
        private IWebDriver driver;

        private IWebElement btnChooseRailcar => driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div/div/div[2]/main/div/div[2]/div[3]/div/div/div[2]/div[1]/div[2]/div/span/span"));
        //place can be not free
        private IWebElement btnChoosePlace => driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div/div/div[2]/main/div/div[2]/div[3]/div/div/div[2]/div[2]/div/div/div/div[1]/div/div[2]/div[1]/div[4]/div/div/div[14]/span"));
        private IWebElement btnEnterPassengerData => driver.FindElement(By.XPath("//a [text()='Ввести данные пассажиров']"));

        public SelectedTrain(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickChooseRailcar() => btnChooseRailcar.Click();
        public void ClickChoosePlace() => btnChoosePlace.Click();
        public void ClickEnterPassengerData() => btnEnterPassengerData.Click();
    }
}

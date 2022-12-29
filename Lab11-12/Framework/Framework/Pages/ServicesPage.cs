using OpenQA.Selenium;

namespace Framework.Pages
{
    public class ServicesPage
    {
        private IWebDriver driver;

        private IWebElement btnConfirmStation => driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div[3]/div[1]/div/div/div/div/div[2]/input[1]"));
        private IWebElement checkHeader => driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div[1]/div/div[1]/div/div/div[2]/div/div[1]/h1"));

        public ServicesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickConfirmStation() => btnConfirmStation.Click();
        public string GetServieceHeader() => checkHeader.Text;
    }
}

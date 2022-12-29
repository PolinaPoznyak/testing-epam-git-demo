using OpenQA.Selenium;

namespace Framework.Pages
{
    public class SearchResultPage
    {
        private IWebDriver _driver;

        private IWebElement checkSerachResult => _driver.FindElement(By.XPath("//div[text()='Результаты поиска']"));

        public SearchResultPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public string GetSerachResultPageHeader() => checkSerachResult.Text;
    }
}

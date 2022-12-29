using OpenQA.Selenium;

namespace Framework.Pages
{
    public class AuthorizationPage
    {
        private IWebDriver driver;

        private IWebElement checkAuthorizationAlertText => driver.FindElement(By.XPath("//p [@class='sch-alert__text']"));

        public AuthorizationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetAlertText() => checkAuthorizationAlertText.Text;
    }
}

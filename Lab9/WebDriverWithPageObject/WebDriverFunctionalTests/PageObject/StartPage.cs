using OpenQA.Selenium;
using PageObjects;

namespace PageObject
{
    public class StartPage : BasePage
    {
        public StartPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement btnSelectExpiration => driver.FindElement(By.Id("select2-postform-expiration-container"));
        private IWebElement btn10Minutes => driver.FindElement(By.XPath("//li[text()='10 Minutes']"));
        private IWebElement btnSelectSintaxHighlighting => driver.FindElement(By.Id("select2-postform-format-container"));
        private IWebElement btnBash => driver.FindElement(By.XPath("//li[text()='Bash']"));
        private IWebElement btnCreateNewPaste => driver.FindElement(By.XPath("//button[@class='btn -big']"));

        private IWebElement inputTextArea => driver.FindElement(By.Id("postform-text"));
        private IWebElement inputTitle => driver.FindElement(By.Id("postform-name"));
        
        public void ClickSelectExpiration() => btnSelectExpiration.Click();
        public void ClickBtn10Minutes() => btn10Minutes.Click();
        public void ClickSelectSintaxHighlighting() => btnSelectSintaxHighlighting.Click();
        public void ClickBtnBash() => btnBash.Click();
        public void ClickBtnCreateNewPaste() => btnCreateNewPaste.Click();

        public void SendTextToInputTextArea(string text) => inputTextArea.SendKeys(text);
        public void SendTextToTitle(string text) => inputTitle.SendKeys(text);
    }
}

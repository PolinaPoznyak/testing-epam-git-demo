using OpenQA.Selenium;
using PageObjects;

namespace PageObject
{
    public class NewPastebinPage : BasePage
    {
        public NewPastebinPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement syntaxHighlighting = driver.FindElement(By.XPath("//a[text()='Bash']"));
        private IWebElement codeFirstLine = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[1]/div/span[1]"));
        private IWebElement codeSecondLine = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[2]/div/span[1]"));
        private IWebElement codeThirdLine = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[3]/div/span[1]"));

        public string GetSyntaxHighlighting() => syntaxHighlighting.Text;
        public string GetCodeFirstLine() => codeFirstLine.Text;
        public string GetCodeSecondLine() => codeSecondLine.Text;
        public string GetCodeThirdLine() => codeThirdLine.Text;
    }
}
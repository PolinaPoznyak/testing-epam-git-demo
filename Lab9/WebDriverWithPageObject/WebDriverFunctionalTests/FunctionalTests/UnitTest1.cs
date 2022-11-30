using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject;
using System;
using Tests;

namespace FunctionalTests
{
    public class Tests : BaseTest
    {
        [Test]
        public void ICanWin()
        {
            StartPage start = new(driver);
            start.SendTextToInputTextArea("Hello from WebDriver");
            start.ClickSelectExpiration();
            start.ClickBtn10Minutes();
            start.SendTextToTitle("helloweb");
            start.ClickBtnCreateNewPaste();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void BringItOn()
        {
            StartPage start = new(driver);
            start.SendTextToInputTextArea("git config --global user.name  \"New Sheriff in Town\" \ngit reset $(git commit - tree HEAD ^{ tree} -m \"Legacy code\") \ngit push origin master --force");

            start.ClickSelectSintaxHighlighting();
            start.ClickBtnBash();

            start.ClickSelectExpiration();
            start.ClickBtn10Minutes();

            start.SendTextToTitle("how to gain dominance among developers");

            start.ClickBtnCreateNewPaste();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            IWebElement syntaxHighlighting = driver.FindElement(By.XPath("//a[text()='Bash']"));
            IWebElement codeFirstLine = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[1]/div/span[1]"));
            IWebElement codeSecondLine = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[2]/div/span[1]"));
            IWebElement codeThirdLine = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[3]/div/span[1]"));

            Assert.AreEqual("how to gain dominance among developers - Pastebin.com", driver.Title);
            Assert.AreEqual("Bash", syntaxHighlighting.Text);
            Assert.AreEqual("git config", codeFirstLine.Text);
            Assert.AreEqual("git reset", codeSecondLine.Text);
            Assert.AreEqual("git push", codeThirdLine.Text);
        }
    }
}
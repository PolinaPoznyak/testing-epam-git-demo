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

            NewPastebinPage newPastebinPage = new(driver);
            string syntaxHighlighting = newPastebinPage.GetSyntaxHighlighting();
            string codeFirstLine = newPastebinPage.GetCodeFirstLine();
            string codeSecondLine = newPastebinPage.GetCodeSecondLine();
            string codeThirdLine = newPastebinPage.GetCodeThirdLine();

            Assert.AreEqual("how to gain dominance among developers - Pastebin.com", driver.Title);
            Assert.AreEqual("Bash", syntaxHighlighting);
            Assert.AreEqual("git config", codeFirstLine);
            Assert.AreEqual("git reset", codeSecondLine);
            Assert.AreEqual("git push", codeThirdLine);
        }
    }
}
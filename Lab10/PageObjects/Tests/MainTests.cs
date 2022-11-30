using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjects;

namespace Tests
{
    public class MainTests : BaseTest
    {
        [Test]
        public void CheckOnlineScoreboard()
        {
            MainPage main = new(driver);
            main.ClickOnlineScoreboard();

            OnlineScoreboardPage onlineScoreboard = new(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            onlineScoreboard.ClickConfirmStation();

            string stationName = onlineScoreboard.GetStationName();
            string expectedStationName = "Минск-Пассажирский";
            Assert.AreEqual(expectedStationName, stationName, $"{expectedStationName} is not equal to {stationName}");
        }

        [Test]
        public void UnauthorizedExecutionOfOrder()
        {
            MainPage main = new(driver);
            main.SendTextToFrom("Берёза-Город");
            main.SendTextToTo("Минск-Пассажирский");
            main.ClickBtnTomorrow();
            main.ClickBtnSearch();
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//div [text()= 'Берёза-Город — Минск-Пассажирский,']")));
           
            SchedulePage schedulePage = new(driver);
            schedulePage.ClickConfirmStation();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            SelectedTrain selectedTrain = new(driver);
            selectedTrain.ClickChooseRailcar();
            Thread.Sleep(5000);
            selectedTrain.ClickChoosePlace();
            Thread.Sleep(5000);
            selectedTrain.ClickEnterPassengerData();
            Thread.Sleep(5000);

            AuthorizationPage authorizationPage = new(driver);
            string alertText = authorizationPage.GetAlertText();
            string expectedStationName = "Покупка доступна только для авторизованных пользователей";

            Assert.AreEqual(expectedStationName, alertText, $"{expectedStationName} is not equal to {alertText}");
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Steps
{
    public class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        //1 test
        public void GoToOnlineScoreboardPage()
        {
            Pages.MainPage mainPage = new(driver);
            mainPage.OpenPage();
            mainPage.ClickOnlineScoreboard();
            Thread.Sleep(3000);
        }
        
        public void ConfirmStationOnlineScoreboard()
        {
            Pages.OnlineScoreboardPage onlineScoreboardPage = new Pages.OnlineScoreboardPage(driver);
            onlineScoreboardPage.ClickConfirmStation();
        }

        public string CheckForStation()
        {
            Pages.OnlineScoreboardPage onlineScoreboardPage = new Pages.OnlineScoreboardPage(driver);
            return onlineScoreboardPage.GetStationName();
        }

        //2 test
        public void SettingRouteForTomorrow()
        {
            Pages.MainPage mainPage = new(driver);
            mainPage.OpenPage();
            mainPage.SendTextToFrom();
            mainPage.SendTextToTo("Минск-Пассажирский");
            mainPage.ClickBtnTomorrow();
            Thread.Sleep(3000);
            mainPage.ClickBtnSearch();
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//div [text()= 'Берёза-Город — Минск-Пассажирский,']")));
        }

        public void ChooseVanInTrain()
        {
            Pages.SchedulePage schedulePage = new(driver);
            schedulePage.ClickToSelectPlace();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        public void ChoosePlaceInVan()
        {
            Pages.SelectedTrain selectedTrain = new(driver);
            selectedTrain.ClickChooseRailcar();
            Thread.Sleep(5000);
            selectedTrain.ClickChoosePlace();
            Thread.Sleep(5000);
            selectedTrain.ClickEnterPassengerData();
            Thread.Sleep(5000);
        }

        public string CheckForUnauthorizedAction()
        {
            Pages.AuthorizationPage authorizationPage = new(driver);
            return authorizationPage.GetAlertText();
        }

        //3 test
        public void GoToServOnTrains()
        {
            Pages.MainPage mainPage = new(driver);
            mainPage.OpenPage();
            mainPage.ClickHrefServOnTrains();
        }

        public void ConfirmStationServ()
        {
            Pages.ServicesPage serviecesPage = new(driver);
            serviecesPage.ClickConfirmStation();
        }

        public string ViewedServiceList()
        {
            Pages.ServicesPage serviecesPage = new(driver);
            return serviecesPage.GetServieceHeader();
        } 
        
        //4 test
        public void ViewInfo()
        {
            Pages.MainPage mainPage = new(driver);
            mainPage.OpenPage();
            mainPage.ClickInfoBtn();
            Thread.Sleep(2000);
            mainPage.ClickServInTrainHref();
            Thread.Sleep(2000);
            mainPage.ClickFreeServHref();
            Thread.Sleep(2000);
        }

        public string ViewedFreeService()
        {
            Pages.MainPage mainPage = new(driver);
            return mainPage.GetFreeServieceHeader();
        }

        //5-6 test
        public void ShooseScheduleByStationNameAndTrainNum()
        {
            Pages.MainPage mainPage = new(driver);
            mainPage.OpenPage();
            mainPage.ClickScheduleByStationNameBtn();
            Thread.Sleep(2000);
        }
        
        //5 test
        public void ShooseScheduleByStationName()
        {
            Pages.MainPage mainPage = new(driver);
            mainPage.SendTextToFromStationName();
            mainPage.ClickBtnScheduleByNameTomorrow();
            mainPage.ClickBtnSearchScheduleByName();
            Thread.Sleep(3000);
        }
        
        public string ViewedScheduleByStationName()
        {
            Pages.SchedulePage schedulePage = new(driver);
            return schedulePage.GetScheduleStationHeader();
        }

        //6 test
        public void ShooseScheduleByTrainNum()
        {
            Pages.MainPage mainPage = new(driver);
            mainPage.ClickChooseByTrainRadioBtn();
            Thread.Sleep(2000);
            mainPage.SendTextToTrainNum();
            mainPage.ClickBtnSearchScheduleByTrainNum();
            Thread.Sleep(3000);
        }

        public string ViewedScheduleByTrainNum()
        {
            Pages.SchedulePage schedulePage = new(driver);
            return schedulePage.GetTrainNum();
        }

        //7 test
        public void MagnifierSearch()
        {
            Pages.MainPage mainPage = new(driver);
            mainPage.OpenPage();
            mainPage.ClickMagnifierBtn();
            Thread.Sleep(2000);
            mainPage.SendTextToInputMagnifier();
            mainPage.ClickMagnifierSearchBtn();
            Thread.Sleep(3000);
        }

        public string ViewedSearchPage()
        {
            Pages.SearchResultPage searchResultPage = new(driver);
            return searchResultPage.GetSerachResultPageHeader();
        }

        //8 test
        public void ChooseVisuallyImpairedVersion()
        {
            Pages.MainPage mainPage = new(driver);
            mainPage.OpenPage();
            mainPage.ClickVersionVisuallyImpairedBtn();
            Thread.Sleep(3000);
            mainPage.ClickSettingsVisuallyImpairedBtn();
            mainPage.ClickSettingsGiorgiaFontBtn();
            mainPage.ClickSettingsEnlargedFontBtn();
            mainPage.ClickSettingsVisuallyImpairedBtn();
            Thread.Sleep(3000);
        }
        
        //9 test
        public void ShooseScheduleOfTrainsWithUnnumberedSeats()
        {
            Pages.MainPage mainPage = new(driver);
            mainPage.OpenPage();
            mainPage.ClickTrainsWithUnnumberedSeatsBtn();
            Thread.Sleep(3000);
            mainPage.SendTextToFromUnnumberedSeats();
            mainPage.SendTextToToUnnumberedSeats();
            mainPage.ClickBtnUnnumberedSeatsTomorrow();
            Thread.Sleep(3000);
            mainPage.ClickBtnSearchUnnumberedSeats();
            Thread.Sleep(3000);
        }

        //10 test
        public void ChangeCurrency()
        {
            Pages.MainPage mainPage = new(driver);
            mainPage.OpenPage();
            mainPage.ClickCurrentCurrencyBtn();
            mainPage.ClickEURCurrencyBtn();
            Thread.Sleep(1000);
        }

        public void SetRouteForFromTo()
        {
            Pages.MainPage mainPage = new(driver);
            mainPage.SendTextToFrom();
            mainPage.SendTextToTo();
            mainPage.ClickBtnTomorrow();
            Thread.Sleep(3000);
            mainPage.ClickBtnSearch();
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//div [text()= 'Берёза-Город — Минск-Пассажирский,']")));
        }

        public string CheckForCurrentCurrency()
        {
            Pages.MainPage mainPage = new(driver);
            return mainPage.GetCurrentCurrency();
        }
    }
}

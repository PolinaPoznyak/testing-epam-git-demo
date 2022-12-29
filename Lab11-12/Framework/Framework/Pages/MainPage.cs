using OpenQA.Selenium;

namespace Framework.Pages
{
    public class MainPage
    {
        private IWebDriver _driver;

        private string BASE_URL = "https://pass.rw.by/ru/";

        //1 test
        private IWebElement btnOnlineScoreboard => _driver.FindElement(By.XPath("//span[text()='Онлайн-табло']"));

        //2 test
        private IWebElement btnWhenTomorrow => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[1]/div[2]/div/div/div[2]/div/div/div[2]/div[1]/form/div/div[2]/div/div[2]/a[2]"));
        private IWebElement btnSearch => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[1]/div[2]/div/div/div[2]/div/div/div[2]/div[1]/form/div/div[3]/button"));

        private IWebElement inputFrom => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[1]/div[2]/div/div/div[2]/div/div/div[2]/div[1]/form/div/div[1]/div[1]/div[1]/input[1]"));
        private IWebElement inputTo => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[1]/div[2]/div/div/div[2]/div/div/div[2]/div[1]/form/div/div[1]/div[2]/div[1]/input[1]"));
        private IWebElement inputWhen => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[1]/div[2]/div/div/div[2]/div/div/div[2]/div[1]/form/div/div[2]/div/div[1]/input[1]"));

        //3 test
        private IWebElement listServOnTrains => _driver.FindElement(By.XPath("//a[text()='Перечень услуг, предоставляемых в поездах']"));

        //4 test
        private IWebElement btnInfo => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/header/div/div[3]/div[3]/ul/li[3]/a"));
        private IWebElement hrefServInTrain => _driver.FindElement(By.XPath("//a[text()='Услуги в поездах']"));
        private IWebElement hrefFreeServ => _driver.FindElement(By.XPath("//a[text()='Бесплатные услуги']"));
        private IWebElement checkHeaderFreeServ => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[8]/div[2]/div[2]/div[2]/div/div/div[1]/div"));

        //5 test
        private IWebElement scheduleByStationNameBtn => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/ul/li[3]/a/span"));
        private IWebElement inputFromStationByName => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[3]/div[2]/div/div/div/div[2]/div[1]/form/div/div[1]/div/div[1]/div/div[1]/input[1]"));
        private IWebElement btnWhenScheduleByNameToday => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[3]/div[2]/div/div/div/div[2]/div[1]/form/div/div[1]/div/div[2]/div/div[2]/a[1]"));
        private IWebElement btnSearchScheduleByName => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[3]/div[2]/div/div/div/div[2]/div[1]/form/div/div[1]/div/div[3]/button"));
        //6 test
        private IWebElement byTrainRadioBtn => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[3]/div[2]/div/div/div/div[1]/ul/li[2]/label/div/div"));
        private IWebElement inputTrainNum => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[3]/div[2]/div/div/div/div[2]/div[2]/form/div/div[1]/div/div[1]/input"));
        private IWebElement btnSearchScheduleByTrainNum => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[3]/div[2]/div/div/div/div[2]/div[2]/form/div/div[2]/button"));

        //7 test
        private IWebElement magnifierBtn => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/header/div/div[2]/div[5]/div[2]/div"));
        private IWebElement inputText => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/header/div/div[2]/div[5]/div[2]/form/div/input[2]"));
        private IWebElement magnifierSearchBtn => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/header/div/div[2]/div[5]/div[2]/form/div/input[1]"));

        //8 test
        private IWebElement versionVisuallyImpairedBtn => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/header/div/div[2]/div[4]/a"));
        private IWebElement settingsVisuallyImpairedBtn => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/header/div/div[1]/div[1]/div[3]/a"));
        private IWebElement settingsEnlargedFontBtn => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/header/div/div[1]/div[2]/div[3]/a[2]/span"));
        private IWebElement settingsGiorgiaFontBtn => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/header/div/div[1]/div[2]/div[2]/a[2]/span"));

        //9 test
        private IWebElement trainsWithUnnumberedSeatsBtn => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/ul/li[2]/a/span"));
        private IWebElement inputFromUnnumberedSeats => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[2]/div[2]/div/div/div/div/div[1]/form/div/div[1]/div[1]/div[1]/input[1]"));
        private IWebElement inputToUnnumberedSeats => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[2]/div[2]/div/div/div/div/div[1]/form/div/div[1]/div[2]/div[1]/input[1]"));
        private IWebElement btnWhenUnnumberedSeatsTomorrow => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[2]/div[2]/div/div/div/div/div[1]/form/div/div[2]/div/div[1]/input[1]"));
        private IWebElement btnSearchUnnumberedSeats => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[2]/div[2]/div/div/div/div/div[1]/form/div/div[3]/button"));
        
        //10 test
        private IWebElement currentCurrencyBtn => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/header/div/div[2]/div[2]/a"));
        private IWebElement currencyEURBtn => _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/header/div/div[2]/div[2]/div/ul/li[3]/a"));
        private IWebElement checkCurrentCurrency => _driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div/div/div[2]/main/div/div[2]/div[4]/div/form/div[1]/div/div/div/div[2]/div[1]/div[1]/span[2]"));

        public MainPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }

        //1 test
        public void ClickOnlineScoreboard() => btnOnlineScoreboard.Click();

        //2 test
        public void ClickBtnTomorrow() => btnWhenTomorrow.Click();
        public void ClickBtnSearch() => btnSearch.Click();

        public void SendTextToFrom(string text = "Берёза-Город") => inputFrom.SendKeys(text);
        public void SendTextToTo(string text = "Минск-Пассажирский") => inputTo.SendKeys(text);
        public void SendTextToWhen(string text) => inputWhen.SendKeys(text);
        
        //3 test
        public void ClickHrefServOnTrains() => listServOnTrains.Click();

        //4 test
        public void ClickInfoBtn() => btnInfo.Click();
        public void ClickServInTrainHref() => hrefServInTrain.Click();
        public void ClickFreeServHref() => hrefFreeServ.Click();
        public string GetFreeServieceHeader() => checkHeaderFreeServ.Text;

        //5 test
        public void SendTextToFromStationName(string text = "Минск-Пассажирский") => inputFromStationByName.SendKeys(text);
        public void ClickBtnScheduleByNameTomorrow() => btnWhenScheduleByNameToday.Click();
        public void ClickBtnSearchScheduleByName() => btnSearchScheduleByName.Click(); public void ClickScheduleByStationNameBtn() => scheduleByStationNameBtn.Click();

        //6 test
        public void ClickChooseByTrainRadioBtn() => byTrainRadioBtn.Click();
        public void SendTextToTrainNum(string text = "727Б") => inputTrainNum.SendKeys(text);
        public void ClickBtnSearchScheduleByTrainNum() => btnSearchScheduleByTrainNum.Click();
    
        //7 test
        public void ClickMagnifierBtn() => magnifierBtn.Click();
        public void SendTextToInputMagnifier(string text = "скидки") => inputText.SendKeys(text);
        public void ClickMagnifierSearchBtn() => magnifierSearchBtn.Click();

        //8 test
        public void ClickVersionVisuallyImpairedBtn() => versionVisuallyImpairedBtn.Click();
        public void ClickSettingsVisuallyImpairedBtn() => settingsVisuallyImpairedBtn.Click();
        public void ClickSettingsGiorgiaFontBtn() => settingsGiorgiaFontBtn.Click();
        public void ClickSettingsEnlargedFontBtn() => settingsEnlargedFontBtn.Click();

        //9 test
        public void ClickTrainsWithUnnumberedSeatsBtn() => trainsWithUnnumberedSeatsBtn.Click();
        public void SendTextToFromUnnumberedSeats(string text = "Берёза-Город") => inputFromUnnumberedSeats.SendKeys(text);
        public void SendTextToToUnnumberedSeats(string text = "Брест-Центральный") => inputToUnnumberedSeats.SendKeys(text);
        public void ClickBtnUnnumberedSeatsTomorrow() => btnWhenUnnumberedSeatsTomorrow.Click();
        public void ClickBtnSearchUnnumberedSeats() => btnSearchUnnumberedSeats.Click();
    
        //10 test
        public void ClickCurrentCurrencyBtn() => currentCurrencyBtn.Click();
        public void ClickEURCurrencyBtn() => currencyEURBtn.Click();
        public string GetCurrentCurrency() => checkCurrentCurrency.Text;

    }
}

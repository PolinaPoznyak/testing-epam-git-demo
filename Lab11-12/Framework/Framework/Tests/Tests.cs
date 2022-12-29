using NUnit.Framework;

namespace Framework.Tests
{
    [TestFixture]
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void CheckOnlineScoreboard()
        {
            steps.GoToOnlineScoreboardPage();
            steps.ConfirmStationOnlineScoreboard();
            Assert.AreEqual("Минск-Пассажирский", steps.CheckForStation(), $"'Минск - Пассажирский' is not equal to {steps.CheckForStation()}");
        }

        [Test]
        public void UnauthorizedExecutionOfOrder()
        {
            string expectedStationName = "Покупка доступна только для авторизованных пользователей";

            steps.SettingRouteForTomorrow();
            steps.ChooseVanInTrain();
            steps.ChoosePlaceInVan();
            Assert.AreEqual(expectedStationName, steps.CheckForUnauthorizedAction(), $"{expectedStationName} is not equal to {steps.CheckForUnauthorizedAction()}");
        }

        [Test]
        public void ListOfServicesPersonsWithDisabilities()
        {
            steps.GoToServOnTrains();
            steps.ConfirmStationServ();
            Assert.AreEqual("Поддержка лиц с ограниченными физическими возможностями", steps.ViewedServiceList(), $"'Поддержка лиц с ограниченными физическими возможностями' is not equal to {steps.ViewedServiceList()}");
        }

        [Test]
        public void FreeServieces()
        {
            steps.ViewInfo();
            Assert.AreEqual("Бесплатные услуги", steps.ViewedFreeService(), $"'Бесплатные услуги' is not equal to {steps.ViewedFreeService()}");
        } 
        
        [Test]
        public void ViewTimetableByStationName()
        {
            steps.ShooseScheduleByStationNameAndTrainNum();
            steps.ShooseScheduleByStationName();
            Assert.AreEqual("Расписание движения по станции", steps.ViewedScheduleByStationName(), $"'Расписание движения по станции' is not equal to {steps.ViewedScheduleByStationName()}");
        }
        
        [Test]
        public void ViewTimetableByTrainNum()
        {
            steps.ShooseScheduleByStationNameAndTrainNum();
            steps.ShooseScheduleByTrainNum();
            Assert.AreEqual("727Б", steps.ViewedScheduleByTrainNum(), $"'727Б' is not equal to {steps.ViewedScheduleByTrainNum()}");
        }

        [Test]
        public void SearchMagnifier()
        {
            steps.MagnifierSearch();
            Assert.AreEqual("Результаты поиска", steps.ViewedSearchPage(), $"'Результаты поиска' is not equal to {steps.ViewedSearchPage()}");
        }

        [Test]
        public void VersionForTheVisuallyImpaired()
        {
            steps.ChooseVisuallyImpairedVersion();
        }
        
        [Test]
        public void ViewTimetableOfTrainsWithUnnumberedSeats()
        {
            steps.ShooseScheduleOfTrainsWithUnnumberedSeats();
        }
        
        [Test]
        public void CurrencyVerification()
        {
            string expectedCurrency = "BYN";

            steps.ChangeCurrency();
            steps.SetRouteForFromTo();
            steps.ChooseVanInTrain();
            steps.ChoosePlaceInVan();
            Assert.AreEqual(expectedCurrency, steps.CheckForCurrentCurrency(), $"'{expectedCurrency}' is not equal to {steps.CheckForCurrentCurrency()}");
        }
    }
}

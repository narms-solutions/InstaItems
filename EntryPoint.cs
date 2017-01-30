

using NUnit.Framework;
using System.Threading;
namespace InstaAndHygiene
{
    public class EntryPoint
    {
        static void Main()
        {
            //Acts.InitializeDriver();
            //Thread.Sleep(1000);
            //Acts.LoginCredentials(Config.HospitalCredentials.MobileNumber, Config.HospitalCredentials.UserCare, Config.HospitalCredentials.PassWord);
            //Thread.Sleep(3000);
            ////////Actss.OwnQualityMethod(Config.MemoText.comment);
            //////Actss.MobileStatistics();
            //Acts.Attendance();
            //Acts.LoginCredentials(Config.WorkOrderOwnQualityCredentials.MobileNumber, Config.WorkOrderOwnQualityCredentials.UserCare, Config.WorkOrderOwnQualityCredentials.PassWord);
            //Thread.Sleep(1000);
            //Actss.WorkOrderOwnQuality();
            //Acts.EventReport(Config.MemoText.Time);

            //Acts.StartUnplannedTask();

           // Acts.MyWorkOrderTask(Config.MemoText.Time);

            //Acts.SevenRoomWorkOrder(Config.MemoText.Time);
            //Acts.LoginCredentials(Config.HospitalCredentials.MobileNumber, Config.HospitalCredentials.UserCare, Config.HospitalCredentials.PassWord);
            
           //Acts.FirstInspection();


            //WebActions.InitializeWebDriver();
            //Thread.Sleep(1000);
            //WebActions.WebloginCredentials(Config.WebLoginCredentials.WebUserCare, Config.WebLoginCredentials.WebPassWord);
            //WebActions.MenuSelection(Config.MemoText.Time);
            //WebActions.screenshot();


            //Acts.LoginCredentials(Config.HygieneCredentials.MobileNumber, Config.HygieneCredentials.UserCare, Config.HygieneCredentials.PassWord);
            //Thread.Sleep(1000);
            ////// Acts.HygieneQualityCheck(Config.MemoText.Time);
            //Acts.HygineApproved(Config.MemoText.Time);

            //Acts.LoginCredentials(Config.MuicipalityCredentials.MobileNumber, Config.MuicipalityCredentials.UserCare, Config.MuicipalityCredentials.PassWord);
            //Acts.MunicipalityInsta(Config.MemoText.Time);


            //Acts.InitializeDriver();
            //Acts.LoginCredentials(Config.FourSingleSampCredentials.MobileNumber, Config.FourSingleSampCredentials.UserCare, Config.FourSingleSampCredentials.PassWord);
            //Acts.BothAppTestCase();
            //Thread.Sleep(1000);
            ////Acts.InitializeDriver();
            //Acts.LoginCredentialsWithOutMobileNumber(Config.FourSingleSampCredentials.UserCare, Config.FourSingleSampCredentials.PassWord);
            //Acts.InstaAppHygieneRejTestCase();
            //Thread.Sleep(1000);
            ////Acts.InitializeDriver();
            //Acts.LoginCredentialsWithOutMobileNumber(Config.FourSingleSampCredentials.UserCare, Config.FourSingleSampCredentials.PassWord);
            //Acts.InstarejHygieneAppTestCase();
            //Thread.Sleep(1000);
            ////Acts.InitializeDriver();
            //Acts.LoginCredentialsWithOutMobileNumber(Config.FourSingleSampCredentials.UserCare, Config.FourSingleSampCredentials.PassWord);
            //Acts.BothRejTestCase();

            //Acts.HptlOwnQualityMethod(Config.MemoText.comment);
            //Acts.MunicipalityOwnQualityMethod(Config.MemoText.comment);


       }
        [SetUp]
        public void Initialize()
        {
            Acts.InitializeDriver();
        }
        [Test]
        public void MobileAttend()
        {
            Acts.LoginCredentials(Config.HospitalCredentials.MobileNumber, Config.HospitalCredentials.UserCare, Config.HospitalCredentials.PassWord);
            Thread.Sleep(1000);
            Acts.Attendance();
            Thread.Sleep(1000);
            Acts.EventReport(Config.MemoText.Time);
            Thread.Sleep(1000);
            Acts.StartUnplannedTask();
        }
        [Test]
        public void MunicipalityWorkOrder()
        {
            Acts.LoginCredentials(Config.MuicipalityCredentials.MobileNumber, Config.MuicipalityCredentials.UserCare, Config.MuicipalityCredentials.PassWord);
            Thread.Sleep(1000);
            Acts.MunicipalityInsta(Config.MemoText.Time);

        }
        [Test]
        public void Casea1WorkOrder()
        {
            Acts.LoginCredentials(Config.HygieneCredentials.MobileNumber, Config.HygieneCredentials.UserCare, Config.HygieneCredentials.PassWord);
            Thread.Sleep(1000);
            // Acts.HygieneQualityCheck(Config.MemoText.Time);
            Acts.HygineApproved(Config.MemoText.Time);

        }
        [Test]
        public void casea2WorkOrder()
        {
            Acts.LoginCredentials(Config.FourSingleSampCredentials.MobileNumber, Config.FourSingleSampCredentials.UserCare, Config.FourSingleSampCredentials.PassWord);
            Acts.BothAppTestCase();
            Thread.Sleep(1000);
            //Acts.InitializeDriver();
            Acts.LoginCredentialsWithOutMobileNumber(Config.FourSingleSampCredentials.UserCare, Config.FourSingleSampCredentials.PassWord);
            Acts.InstaAppHygieneRejTestCase();
            Thread.Sleep(1000);
            //Acts.InitializeDriver();
            Acts.LoginCredentialsWithOutMobileNumber(Config.FourSingleSampCredentials.UserCare, Config.FourSingleSampCredentials.PassWord);
            Acts.InstarejHygieneAppTestCase();
            Thread.Sleep(1000);
            //Acts.InitializeDriver();
            Acts.LoginCredentialsWithOutMobileNumber(Config.FourSingleSampCredentials.UserCare, Config.FourSingleSampCredentials.PassWord);
            Acts.BothRejTestCase();
        }
        [Test]
        public void HospitalOwnQuality()
        {
            Acts.LoginCredentials(Config.HospitalCredentials.MobileNumber, Config.HospitalCredentials.UserCare, Config.HospitalCredentials.PassWord);
            Thread.Sleep(1000);
            Acts.HptlOwnQualityMethod(Config.MemoText.comment);
        }
        [Test]
        public void MunicipalityOwmQuality()
        {
            Acts.LoginCredentials(Config.HospitalCredentials.MobileNumber, Config.HospitalCredentials.UserCare, Config.HospitalCredentials.PassWord);
            Thread.Sleep(1000);
            Actss.OwnQualityMethod(Config.MemoText.comment);
        }
        [Test]
        public void WebReports()
        {
            WebActions.InitializeWebDriver();
            Thread.Sleep(1000);
            WebActions.WebloginCredentials(Config.WebLoginCredentials.WebUserCare, Config.WebLoginCredentials.WebPassWord);
            Thread.Sleep(1000);
            WebActions.MenuSelection(Config.MemoText.Time);
            //WebActions.screenshot();

        }
        [Test]
        public void WorkOrderOwnQualityMethod()
        {
            Acts.LoginCredentials(Config.WorkOrderOwnQualityCredentials.MobileNumber, Config.WorkOrderOwnQualityCredentials.UserCare, Config.WorkOrderOwnQualityCredentials.PassWord);
            Thread.Sleep(1000);
            Actss.WorkOrderRoomOwnQuality();
            Thread.Sleep(1000);
            Actss.WorkOrderUnitOwnQuality(Config.MemoText.comment);
        }
        [TearDown]
        public void CleanUp()
        {

            // Actions.InitializeDriver();
            //Driver.driver.Quit();

        }
    }
}

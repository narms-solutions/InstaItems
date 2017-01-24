

using System.Threading;
namespace InstaAndHygiene
{
    public class EntryPoint
    {
        static void Main()
        {
            Acts.InitializeDriver();
            Thread.Sleep(1000);
            Acts.LoginCredentials(Config.HospitalCredentials.MobileNumber, Config.HospitalCredentials.UserCare, Config.HospitalCredentials.PassWord);
            //Thread.Sleep(3000);
            Actss.OwnQualityMethod(Config.MemoText.comment);
            //Actss.MobileStatistics();
            ////Acts.Attendance();

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
            ////WebActions.screenshot();


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
    }
}

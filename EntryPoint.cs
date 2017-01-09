

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
            ////Thread.Sleep(3000);

            ////Actions.Attendance();

            //Actions.EventReport(Config.MemoText.Time);

            //Actions.StartUnplannedTask();

           // Acts.MyWorkOrderTask(Config.MemoText.Time);

            //Acts.SevenRoomWorkOrder(Config.MemoText.Time);
           // Acts.FirstInspection();


            WebActions.InitializeWebDriver();
            Thread.Sleep(1000);
            WebActions.WebloginCredentials(Config.WebLoginCredentials.WebUserCare, Config.WebLoginCredentials.WebPassWord);
            WebActions.MenuSelection();

            //Acts.LoginCredentials(Config.HygieneCredentials.MobileNumber, Config.HygieneCredentials.UserCare, Config.HygieneCredentials.PassWord);
            //Thread.Sleep(1000);
            //Acts.HygieneQualityCheck(Config.MemoText.Time);

            //Acts.LoginCredentials(Config.MuicipalityCredentials.MobileNumber, Config.MuicipalityCredentials.UserCare, Config.MuicipalityCredentials.PassWord);
            //Acts.MunicipalityInsta();
        }
    }
}
